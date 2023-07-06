namespace WindowsFormsUtilitariosSap
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dataGridViewAnalysis = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercertangeSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercertangeExist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelAnalysisStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAnalysisExportExcel = new System.Windows.Forms.Button();
            this.buttonExecuteAnalysis = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listBoxAnalisisLoadProducts = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonAnalysisLoadProduct = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.listBoxAnalysisStores = new System.Windows.Forms.ListBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.checkBoxAnalysisStores = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysis)).BeginInit();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.panel11, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1109, 616);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.dataGridViewAnalysis);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(224, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(882, 610);
            this.panel11.TabIndex = 8;
            // 
            // dataGridViewAnalysis
            // 
            this.dataGridViewAnalysis.AllowUserToAddRows = false;
            this.dataGridViewAnalysis.AllowUserToDeleteRows = false;
            this.dataGridViewAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Code,
            this.Description,
            this.Date,
            this.Stock,
            this.Entry,
            this.Output,
            this.Ajust,
            this.StockClose,
            this.PercertangeSold,
            this.PercertangeExist,
            this.LastEntry,
            this.PriceDollar});
            this.dataGridViewAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAnalysis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAnalysis.Name = "dataGridViewAnalysis";
            this.dataGridViewAnalysis.ReadOnly = true;
            this.dataGridViewAnalysis.Size = new System.Drawing.Size(880, 568);
            this.dataGridViewAnalysis.TabIndex = 1;
            this.dataGridViewAnalysis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnalysis_CellClick);
            // 
            // Image
            // 
            this.Image.DataPropertyName = "IMAGE_SET";
            this.Image.HeaderText = "Imagen";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "MATNR";
            this.Code.HeaderText = "Codigo Articulo";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "MAKTX";
            this.Description.HeaderText = "Descripción de articulo";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "BUDAT";
            this.Date.HeaderText = "Fecha contabilización";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "LABST";
            this.Stock.HeaderText = "Stock Almacen";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Entry
            // 
            this.Entry.DataPropertyName = "MENGE_1";
            this.Entry.HeaderText = "Entrada";
            this.Entry.Name = "Entry";
            this.Entry.ReadOnly = true;
            // 
            // Output
            // 
            this.Output.DataPropertyName = "MENGE_2";
            this.Output.HeaderText = "Salida";
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            // 
            // Ajust
            // 
            this.Ajust.DataPropertyName = "MENGE_4";
            this.Ajust.HeaderText = "Ajuste";
            this.Ajust.Name = "Ajust";
            this.Ajust.ReadOnly = true;
            // 
            // StockClose
            // 
            this.StockClose.DataPropertyName = "MENGE_3";
            this.StockClose.HeaderText = "Stock Cierre";
            this.StockClose.Name = "StockClose";
            this.StockClose.ReadOnly = true;
            // 
            // PercertangeSold
            // 
            this.PercertangeSold.DataPropertyName = "VENTA";
            this.PercertangeSold.HeaderText = "Porcentaje Venta";
            this.PercertangeSold.Name = "PercertangeSold";
            this.PercertangeSold.ReadOnly = true;
            // 
            // PercertangeExist
            // 
            this.PercertangeExist.DataPropertyName = "EXIST";
            this.PercertangeExist.HeaderText = "Porcentaje Existencia";
            this.PercertangeExist.Name = "PercertangeExist";
            this.PercertangeExist.ReadOnly = true;
            // 
            // LastEntry
            // 
            this.LastEntry.DataPropertyName = "MENGE_I";
            this.LastEntry.HeaderText = "Ultima Entrada";
            this.LastEntry.Name = "LastEntry";
            this.LastEntry.ReadOnly = true;
            // 
            // PriceDollar
            // 
            this.PriceDollar.DataPropertyName = "KBETR_A";
            this.PriceDollar.HeaderText = "Precio Dolar";
            this.PriceDollar.Name = "PriceDollar";
            this.PriceDollar.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.labelAnalysisStatus);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.buttonAnalysisExportExcel);
            this.panel12.Controls.Add(this.buttonExecuteAnalysis);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 568);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(880, 40);
            this.panel12.TabIndex = 0;
            // 
            // labelAnalysisStatus
            // 
            this.labelAnalysisStatus.AutoSize = true;
            this.labelAnalysisStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalysisStatus.ForeColor = System.Drawing.Color.Red;
            this.labelAnalysisStatus.Location = new System.Drawing.Point(85, 9);
            this.labelAnalysisStatus.Name = "labelAnalysisStatus";
            this.labelAnalysisStatus.Size = new System.Drawing.Size(0, 20);
            this.labelAnalysisStatus.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estatus:";
            // 
            // buttonAnalysisExportExcel
            // 
            this.buttonAnalysisExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnalysisExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalysisExportExcel.Location = new System.Drawing.Point(528, 3);
            this.buttonAnalysisExportExcel.Name = "buttonAnalysisExportExcel";
            this.buttonAnalysisExportExcel.Size = new System.Drawing.Size(169, 33);
            this.buttonAnalysisExportExcel.TabIndex = 4;
            this.buttonAnalysisExportExcel.Text = "Exportar Excel";
            this.buttonAnalysisExportExcel.UseVisualStyleBackColor = true;
            this.buttonAnalysisExportExcel.Click += new System.EventHandler(this.buttonAnalysisExportExcel_Click);
            // 
            // buttonExecuteAnalysis
            // 
            this.buttonExecuteAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecuteAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecuteAnalysis.Location = new System.Drawing.Point(703, 3);
            this.buttonExecuteAnalysis.Name = "buttonExecuteAnalysis";
            this.buttonExecuteAnalysis.Size = new System.Drawing.Size(172, 33);
            this.buttonExecuteAnalysis.TabIndex = 3;
            this.buttonExecuteAnalysis.Text = "Ejecutar Analisis";
            this.buttonExecuteAnalysis.UseVisualStyleBackColor = true;
            this.buttonExecuteAnalysis.Click += new System.EventHandler(this.buttonExecuteAnalysis_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(215, 610);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 299);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listBoxAnalisisLoadProducts);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 226);
            this.panel6.TabIndex = 3;
            // 
            // listBoxAnalisisLoadProducts
            // 
            this.listBoxAnalisisLoadProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAnalisisLoadProducts.FormattingEnabled = true;
            this.listBoxAnalisisLoadProducts.Location = new System.Drawing.Point(0, 0);
            this.listBoxAnalisisLoadProducts.Name = "listBoxAnalisisLoadProducts";
            this.listBoxAnalisisLoadProducts.ScrollAlwaysVisible = true;
            this.listBoxAnalisisLoadProducts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAnalisisLoadProducts.Size = new System.Drawing.Size(207, 226);
            this.listBoxAnalisisLoadProducts.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonAnalysisLoadProduct);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 264);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 33);
            this.panel7.TabIndex = 2;
            // 
            // buttonAnalysisLoadProduct
            // 
            this.buttonAnalysisLoadProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalysisLoadProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalysisLoadProduct.Location = new System.Drawing.Point(0, 0);
            this.buttonAnalysisLoadProduct.Name = "buttonAnalysisLoadProduct";
            this.buttonAnalysisLoadProduct.Size = new System.Drawing.Size(207, 33);
            this.buttonAnalysisLoadProduct.TabIndex = 2;
            this.buttonAnalysisLoadProduct.Text = "Cargar Articulos";
            this.buttonAnalysisLoadProduct.UseVisualStyleBackColor = true;
            this.buttonAnalysisLoadProduct.Click += new System.EventHandler(this.buttonAnalysisLoadProduct_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 38);
            this.panel5.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Cargar Articulos:";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 308);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(209, 299);
            this.panel8.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.listBoxAnalysisStores);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(207, 226);
            this.panel10.TabIndex = 4;
            // 
            // listBoxAnalysisStores
            // 
            this.listBoxAnalysisStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAnalysisStores.FormattingEnabled = true;
            this.listBoxAnalysisStores.Location = new System.Drawing.Point(0, 0);
            this.listBoxAnalysisStores.Name = "listBoxAnalysisStores";
            this.listBoxAnalysisStores.ScrollAlwaysVisible = true;
            this.listBoxAnalysisStores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAnalysisStores.Size = new System.Drawing.Size(207, 226);
            this.listBoxAnalysisStores.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.checkBoxAnalysisStores);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 264);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(207, 33);
            this.panel13.TabIndex = 3;
            // 
            // checkBoxAnalysisStores
            // 
            this.checkBoxAnalysisStores.AutoSize = true;
            this.checkBoxAnalysisStores.Location = new System.Drawing.Point(7, 9);
            this.checkBoxAnalysisStores.Name = "checkBoxAnalysisStores";
            this.checkBoxAnalysisStores.Size = new System.Drawing.Size(155, 17);
            this.checkBoxAnalysisStores.TabIndex = 0;
            this.checkBoxAnalysisStores.Text = "Seleccionar/Deseleccionar";
            this.checkBoxAnalysisStores.UseVisualStyleBackColor = true;
            this.checkBoxAnalysisStores.CheckedChanged += new System.EventHandler(this.checkBoxAnalysisStores_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(207, 38);
            this.panel9.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Seleccionar Tiendas:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 616);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilitarios SAP";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysis)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dataGridViewAnalysis;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelAnalysisStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAnalysisExportExcel;
        private System.Windows.Forms.Button buttonExecuteAnalysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox listBoxAnalisisLoadProducts;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonAnalysisLoadProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListBox listBoxAnalysisStores;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.CheckBox checkBoxAnalysisStores;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ajust;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercertangeSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercertangeExist;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDollar;
    }
}

