﻿using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.Abstractions
{
    // The Builder Abstract Class specifies methods for creating the different parts
    // of the Product objects.
    internal abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
