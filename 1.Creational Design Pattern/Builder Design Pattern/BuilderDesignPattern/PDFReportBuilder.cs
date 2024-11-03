﻿using BuilderDesignPattern.Abstractions;

namespace BuilderDesignPattern
{
    // The Following Concrete Builder Implementd the ReportBuilder Abstract Class and 
    // provide specific implementations of the steps for Creating PDFReport. 
    internal class PDFReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
}
