# How to handle server-side errors in web reporting controls

This example demonstrates how to process errors that occur on web reporting controls' server side.

* The [ReportDesignerExceptionHandler](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ReportDesigner.Services.ReportDesignerExceptionHandler) class is used for the [End-User Report Designer](xref:17103) control.
* The [WebDocumentViewerExceptionHandler](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerExceptionHandler) class is used for the separate [Web Document Viewer](xref:17738) control and the Report Designer's built-in Document Viewer.

These classes expose the following methods:
* [GetExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetExceptionMessage(System.Exception)) to handle all possible errors independently from their types;
* [GetDocumentCreationExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerExceptionHandler.GetDocumentCreationExceptionMessage(DocumentCreationException)) to handle errors related to the document creation process;
* [GetFaultExceptionMessage](http://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetFaultExceptionMessage(System.ServiceModel.FaultException)) to handle [FaultException](https://docs.microsoft.com/en-us/dotnet/api/system.servicemodel.faultexception);
* [GetUnknownExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetUnknownExceptionMessage(System.Exception)) to handle other unknown exceptions, for which reporting controls show the standard 'Internal Server Error' message.

This example contains several report layouts and emulates exceptions that can be raised when you work with reporting controls. 

The following table lists errors from this example and methods used to process these errors.

| Sample Error | Exception Type | Processing Method |
|---|---|---|
| Broken Report Layout | [XmlException](https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlexception) | [GetUnknownExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetUnknownExceptionMessage(System.Exception))|
| File Not Found | [FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception) | [GetUnknownExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetUnknownExceptionMessage(System.Exception))|
| Standard Exception on BeforePrint | [NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception) | [GetDocumentCreationExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerExceptionHandler.GetDocumentCreationExceptionMessage(DocumentCreationException))
| Custom Exception on BeforePrint | MyCustomException (descendant from [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | [GetDocumentCreationExceptionMessage](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerExceptionHandler.GetDocumentCreationExceptionMessage(DocumentCreationException))
| Invalid Report URL (Designer) | [FaultException](https://docs.microsoft.com/en-us/dotnet/api/system.servicemodel.faultexception) | [GetFaultExceptionMessage](http://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetFaultExceptionMessage(System.ServiceModel.FaultException))
| Custom Document Operation (Viewer) | [FaultException](https://docs.microsoft.com/en-us/dotnet/api/system.servicemodel.faultexception) | [GetFaultExceptionMessage](http://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.ClientControls.ExceptionHandler.GetFaultExceptionMessage(System.ServiceModel.FaultException))


**Note**

This examples targets the ASP.NET WebForms platform, but you can use the shown exception handler implementations in ASP.NET MVC applications. 
