﻿
namespace GetForeignExchangeRate
{
    partial class ForeignExchangeRating
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cboBaseCurrencyType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.baseCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboQuoteCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.quoteCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditBaseCRate = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditQuoteCRate = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.textEditHaritsaa = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBaseCurrencyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuoteCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaseCRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuoteCRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHaritsaa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEditQuoteCRate);
            this.layoutControl1.Controls.Add(this.textEditBaseCRate);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.cboQuoteCurrency);
            this.layoutControl1.Controls.Add(this.cboBaseCurrencyType);
            this.layoutControl1.Controls.Add(this.textEditHaritsaa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 193, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(548, 151);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.baseCurrency,
            this.quoteCurrency,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(548, 151);
            this.Root.TextVisible = false;
            // 
            // cboBaseCurrencyType
            // 
            this.cboBaseCurrencyType.Location = new System.Drawing.Point(136, 12);
            this.cboBaseCurrencyType.Name = "cboBaseCurrencyType";
            this.cboBaseCurrencyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBaseCurrencyType.Properties.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "CHF",
            "SEK",
            "GBP",
            "BGN",
            "HUF",
            "EGP",
            "INR",
            "HKD",
            "RUB",
            "KZT",
            "CNY",
            "KRW",
            "KPW",
            "CAD",
            "AUD",
            "CZK",
            "TWD",
            "THB",
            "IDR",
            "MYR",
            "SGD",
            "AED",
            "KWD",
            "NZD",
            "DKK",
            "PLN",
            "UAH",
            "NOK",
            "NPR",
            "ZAR",
            "TRY",
            "VND",
            "XAU",
            "XAG",
            "SDR"});
            this.cboBaseCurrencyType.Size = new System.Drawing.Size(135, 20);
            this.cboBaseCurrencyType.StyleController = this.layoutControl1;
            this.cboBaseCurrencyType.TabIndex = 4;
            // 
            // baseCurrency
            // 
            this.baseCurrency.Control = this.cboBaseCurrencyType;
            this.baseCurrency.Location = new System.Drawing.Point(0, 0);
            this.baseCurrency.Name = "baseCurrency";
            this.baseCurrency.Size = new System.Drawing.Size(263, 24);
            this.baseCurrency.Text = "Base Currency";
            this.baseCurrency.TextSize = new System.Drawing.Size(112, 14);
            // 
            // cboQuoteCurrency
            // 
            this.cboQuoteCurrency.Location = new System.Drawing.Point(399, 12);
            this.cboQuoteCurrency.Name = "cboQuoteCurrency";
            this.cboQuoteCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuoteCurrency.Properties.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "CHF",
            "SEK",
            "GBP",
            "BGN",
            "HUF",
            "EGP",
            "INR",
            "HKD",
            "RUB",
            "KZT",
            "CNY",
            "KRW",
            "KPW",
            "CAD",
            "AUD",
            "CZK",
            "TWD",
            "THB",
            "IDR",
            "MYR",
            "SGD",
            "AED",
            "KWD",
            "NZD",
            "DKK",
            "PLN",
            "UAH",
            "NOK",
            "NPR",
            "ZAR",
            "TRY",
            "VND",
            "XAU",
            "XAG",
            "SDR"});
            this.cboQuoteCurrency.Size = new System.Drawing.Size(137, 20);
            this.cboQuoteCurrency.StyleController = this.layoutControl1;
            this.cboQuoteCurrency.TabIndex = 5;
            // 
            // quoteCurrency
            // 
            this.quoteCurrency.Control = this.cboQuoteCurrency;
            this.quoteCurrency.Location = new System.Drawing.Point(263, 0);
            this.quoteCurrency.Name = "quoteCurrency";
            this.quoteCurrency.Size = new System.Drawing.Size(265, 24);
            this.quoteCurrency.Text = "Quote Currency";
            this.quoteCurrency.TextSize = new System.Drawing.Size(112, 14);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(524, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "See exchange rating";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(528, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // textEditBaseCRate
            // 
            this.textEditBaseCRate.Location = new System.Drawing.Point(136, 95);
            this.textEditBaseCRate.Name = "textEditBaseCRate";
            this.textEditBaseCRate.Size = new System.Drawing.Size(135, 20);
            this.textEditBaseCRate.StyleController = this.layoutControl1;
            this.textEditBaseCRate.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEditBaseCRate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 83);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem6.Text = "Base currency rate";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(112, 14);
            // 
            // textEditQuoteCRate
            // 
            this.textEditQuoteCRate.Location = new System.Drawing.Point(399, 95);
            this.textEditQuoteCRate.Name = "textEditQuoteCRate";
            this.textEditQuoteCRate.Size = new System.Drawing.Size(137, 20);
            this.textEditQuoteCRate.StyleController = this.layoutControl1;
            this.textEditQuoteCRate.TabIndex = 10;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEditQuoteCRate;
            this.layoutControlItem5.Location = new System.Drawing.Point(263, 83);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(265, 24);
            this.layoutControlItem5.Text = "Quote currency rate";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(112, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(528, 33);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // textEditHaritsaa
            // 
            this.textEditHaritsaa.Location = new System.Drawing.Point(136, 119);
            this.textEditHaritsaa.Name = "textEditHaritsaa";
            this.textEditHaritsaa.Size = new System.Drawing.Size(400, 20);
            this.textEditHaritsaa.StyleController = this.layoutControl1;
            this.textEditHaritsaa.TabIndex = 9;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditHaritsaa;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "haritsaa";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 107);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(528, 24);
            this.layoutControlItem1.Text = "Харьцаа";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(112, 14);
            // 
            // ForeignExchangeRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 151);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ForeignExchangeRating";
            this.Text = "Вальтын ханш(Монгол Банк)";
            this.Load += new System.EventHandler(this.ForeignExchangeRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBaseCurrencyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuoteCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBaseCRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuoteCRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHaritsaa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit textEditQuoteCRate;
        private DevExpress.XtraEditors.TextEdit textEditBaseCRate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuoteCurrency;
        private DevExpress.XtraEditors.ComboBoxEdit cboBaseCurrencyType;
        private DevExpress.XtraLayout.LayoutControlItem baseCurrency;
        private DevExpress.XtraLayout.LayoutControlItem quoteCurrency;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit textEditHaritsaa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}