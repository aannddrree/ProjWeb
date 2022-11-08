namespace ProjetoApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet = new ProjetoApp._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet();
            this.graficoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficoTableAdapter = new ProjetoApp._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSetTableAdapters.GraficoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.graficoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(86, 49);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart1.Size = new System.Drawing.Size(520, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // _ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet
            // 
            this._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet.DataSetName = "_ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet";
            this._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graficoBindingSource
            // 
            this.graficoBindingSource.DataMember = "Grafico";
            this.graficoBindingSource.DataSource = this._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet;
            // 
            // graficoTableAdapter
            // 
            this.graficoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private _ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet _ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSet;
        private System.Windows.Forms.BindingSource graficoBindingSource;
        private _ProjWebContext_65c97a07_e0f1_4c2e_ad8c_f75ac8a32e3bDataSetTableAdapters.GraficoTableAdapter graficoTableAdapter;
    }
}

