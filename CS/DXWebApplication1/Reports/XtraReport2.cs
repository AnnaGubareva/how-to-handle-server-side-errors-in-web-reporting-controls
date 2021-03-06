﻿using System;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport2
/// </summary>
public class XtraReport2 : XtraReport {
	private TopMarginBand TopMargin;
	private BottomMarginBand BottomMargin;
	private DetailBand Detail;
	private XRLabel xrLabel1;

	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport2() {
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}

	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
		this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
		this.Detail = new DevExpress.XtraReports.UI.DetailBand();
		this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
		this.BeforePrint += XtraReport2_BeforePrint;
		((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		// 
		// TopMargin
		// 
		this.TopMargin.Name = "TopMargin";
		// 
		// BottomMargin
		// 
		this.BottomMargin.Name = "BottomMargin";
		// 
		// Detail
		// 
		this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
			this.xrLabel1});
		this.Detail.Name = "Detail";
		// 
		// xrLabel1
		// 
		this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(33.33333F, 10.00001F);
		this.xrLabel1.Multiline = true;
		this.xrLabel1.Name = "xrLabel1";
		this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
		this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
		this.xrLabel1.Text = "xrLabel1";
		// 
		// XtraReport2
		// 
		this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
			this.TopMargin,
			this.BottomMargin,
			this.Detail});
		this.Font = new System.Drawing.Font("Arial", 9.75F);
		this.Version = "18.2";
		((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	private void XtraReport2_BeforePrint(object sender, EventArgs e) {
		throw new NotImplementedException();
	}
	#endregion
}
