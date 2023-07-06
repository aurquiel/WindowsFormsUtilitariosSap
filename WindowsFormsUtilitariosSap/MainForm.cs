using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsUtilitariosSap.Backend.DTOs;
using WindowsFormsUtilitariosSap.Backend.Excel;
using WindowsFormsUtilitariosSap.Backend.Models;
using WindowsFormsUtilitariosSap.Backend.Services.Files;
using WindowsFormsUtilitariosSap.Backend.Services.SQL;

namespace WindowsFormsUtilitariosSap
{
    public partial class MainForm : Form
    {
        private readonly string STORES;
        private readonly int MAX_QUANTITY_ARTICLES;

        private IList<AnalysisDataFull> analysisDataFull = new List<AnalysisDataFull>();

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            try
            {
                STORES = ConfigurationManager.AppSettings["STORES"];
            }
            catch
            {
                STORES = string.Empty;
            }

            try
            {
                MAX_QUANTITY_ARTICLES = Int32.Parse(ConfigurationManager.AppSettings["MAX_QUANTITY_ARTICLES"]);
            }
            catch
            {
                MAX_QUANTITY_ARTICLES = 100;
            }

            LoadListBoxAnalisisStore();
        }

        private void LoadListBoxAnalisisStore()
        {
            try
            {
                listBoxAnalysisStores.Items.Clear();
                string[] stores = STORES.Split(',');
                stores = stores.OrderBy(x => x).ToArray();
                foreach (string store in stores)
                {
                    listBoxAnalysisStores.Items.Add(store);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tiendas.", "Error, Excepcion: " + ex.Message.ToLower(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxAnalysisStores_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnalysisStores.CheckState == CheckState.Checked)
            {
                listBoxAnalysisStores.BeginUpdate();

                for (int i = 0; i < listBoxAnalysisStores.Items.Count; i++)
                    listBoxAnalysisStores.SetSelected(i, true);

                listBoxAnalysisStores.EndUpdate();
            }
            else
            {
                listBoxAnalysisStores.BeginUpdate();

                for (int i = 0; i < listBoxAnalysisStores.Items.Count; i++)
                    listBoxAnalysisStores.SetSelected(i, false);

                listBoxAnalysisStores.EndUpdate();
            }
        }

        private void buttonAnalysisLoadProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = $"text|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBoxAnalisisLoadProducts.Items.Clear();
                LoadProductAnalysis(openFileDialog.FileName);
            }
        }

        private void LoadProductAnalysis(string pathFile)
        {
            try
            {
                List<string> products = new List<string>(File.ReadAllLines(pathFile));
                products = products.Where(x => !string.IsNullOrEmpty(x)).ToList();

                if (products.Count > MAX_QUANTITY_ARTICLES)
                {
                    MessageBox.Show("Error ha superado el maximo de artículos a consultar, valor maximo: " + MAX_QUANTITY_ARTICLES, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach(var item in products)
                {
                    listBoxAnalisisLoadProducts.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                listBoxAnalisisLoadProducts.DataSource = null;
                MessageBox.Show("Error al cargar articulos.", "Error, Excepcion: " + ex.Message.ToLower(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedStoresAnalysis()
        {
            string items = string.Empty;

            foreach (int i in listBoxAnalysisStores.SelectedIndices)
            {

                items += listBoxAnalysisStores.Items[i] + ",";
            }

            items = items.TrimEnd(',');
            return items;
        }

        private string GetProductsAnalysis()
        {
            string items = string.Empty;
            foreach (string item in listBoxAnalisisLoadProducts.Items)
            {
                items += item + ",";
            }

            items = items.TrimEnd(',');
            return items;
        }


        private async void buttonExecuteAnalysis_Click(object sender, EventArgs e)
        {
            if (listBoxAnalysisStores.SelectedIndices.Count <= 0 || listBoxAnalisisLoadProducts.Items.Count <= 0)
            {
                MessageBox.Show("Error deden haber productos cargados y por lo menos una tienda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            buttonExecuteAnalysis.Text = "Ejecutando Analisis";
            buttonExecuteAnalysis.Enabled = false;
            buttonAnalysisExportExcel.Enabled = false;
            labelAnalysisStatus.Text = "Ejecutando analisis, por favor espere...";

            AnalysisSQL analysisSQL = new AnalysisSQL();
            Tuple<bool, string, List<AnalysisDataDto>> result = await analysisSQL.GetSalesAnalysis(GetSelectedStoresAnalysis(), GetProductsAnalysis());

            if(result.Item1 == true)
            {
                FilesInternal ftp = new FilesInternal();
                List<AnalysisDataDto> itemWtihImages = await ftp.GetImageOfProduct(result.Item3);
                analysisDataFull = AnalysisDataFull.ParseFromDto(itemWtihImages);
                IList<AnalysisData> itemFinal = AnalysisData.ParseFromFull(analysisDataFull);
                dataGridViewAnalysis.DataSource = itemFinal;
                StyleDatagridViewAnalysis();
            }
            else
            {
                buttonExecuteAnalysis.Text = "Ejecutar Analisis";
                buttonExecuteAnalysis.Enabled = true;
                buttonAnalysisExportExcel.Enabled = true;
                labelAnalysisStatus.Text = result.Item2;
                return;
            }

            buttonExecuteAnalysis.Text = "Ejecutar Analisis";
            buttonExecuteAnalysis.Enabled = true;
            buttonAnalysisExportExcel.Enabled = true;
            labelAnalysisStatus.Text = string.Empty;
        }

        private void StyleDatagridViewAnalysis()
        {
            foreach (DataGridViewRow row in dataGridViewAnalysis.Rows)
            {
                row.Height = 110;
            }

            for(int i = 1; i< dataGridViewAnalysis.Columns.Count; i++)
            {
                dataGridViewAnalysis.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dataGridViewAnalysis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if(analysisDataFull[e.RowIndex].IMAGE_SET_VALUE == false)
                {
                    ((IList<AnalysisData>)dataGridViewAnalysis.DataSource)[e.RowIndex].IMAGE_SET = analysisDataFull[e.RowIndex].IMAGE_REAL_SIZE;
                    analysisDataFull[e.RowIndex].IMAGE_SET_VALUE = true;
                    dataGridViewAnalysis.Rows[e.RowIndex].Height = ((IList<AnalysisData>)dataGridViewAnalysis.DataSource).Max(x => x.IMAGE_SET.Height);
                    dataGridViewAnalysis.Columns[e.ColumnIndex].Width = ((IList<AnalysisData>)dataGridViewAnalysis.DataSource).Max(x => x.IMAGE_SET.Width);
                }
                else
                {
                    ((IList<AnalysisData>)dataGridViewAnalysis.DataSource)[e.RowIndex].IMAGE_SET = analysisDataFull[e.RowIndex].IMAGE_SMALL_SIZE;
                    analysisDataFull[e.RowIndex].IMAGE_SET_VALUE = false;
                    dataGridViewAnalysis.Rows[e.RowIndex].Height = analysisDataFull[e.RowIndex].IMAGE_SET.Height + 2;
                    dataGridViewAnalysis.Columns[e.ColumnIndex].Width = ((IList<AnalysisData>)dataGridViewAnalysis.DataSource).Max(x => x.IMAGE_SET.Width);
                }
            }
        }

        private async void buttonAnalysisExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnalysis.Rows.Count <= 0)
            {
                MessageBox.Show("Error data vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buttonExecuteAnalysis.Enabled = false;
                buttonAnalysisExportExcel.Enabled = false;
                buttonAnalysisExportExcel.Text = "Exportando a Excel";
                labelAnalysisStatus.Text = "Exportando a Excel, por favor espere...";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.Title = "Save XLSX File";
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "XLSX";
                saveFileDialog.Filter = "XLSX files (*.xlsx)|*.xlsx";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var result = await ManageExcel.Create((IList<AnalysisData>)(dataGridViewAnalysis.DataSource), saveFileDialog.FileName);

                    if(result.Item1)
                    {
                        MessageBox.Show(result.Item2, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(result.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                buttonExecuteAnalysis.Enabled = true;
                buttonAnalysisExportExcel.Enabled = true;
                buttonAnalysisExportExcel.Text = "Exportar a Excel";
                labelAnalysisStatus.Text = string.Empty;
            }
        }

        
    }
}
