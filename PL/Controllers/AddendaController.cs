﻿using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class AddendaController : Controller
    {
        // GET: Addenda
        public ActionResult InvocarWS()
        {
            ML.inputMessage inputMessage = new ML.inputMessage();

            inputMessage.cfdi64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<cfdi:Comprobante xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" Total=\"116.00\" Fecha=\"2022-11-23T12:49:50\" LugarExpedicion=\"26015\" MetodoPago=\"PPD\" TipoDeComprobante=\"I\" TipoCambio=\"20.00\" Moneda=\"USD\" Certificado=\"MIIFuzCCA6OgAwIBAgIUMzAwMDEwMDAwMDA0MDAwMDI0MzQwDQYJKoZIhvcNAQELBQAwggErMQ8wDQYDVQQDDAZBQyBVQVQxLjAsBgNVBAoMJVNFUlZJQ0lPIERFIEFETUlOSVNUUkFDSU9OIFRSSUJVVEFSSUExGjAYBgNVBAsMEVNBVC1JRVMgQXV0aG9yaXR5MSgwJgYJKoZIhvcNAQkBFhlvc2Nhci5tYXJ0aW5lekBzYXQuZ29iLm14MR0wGwYDVQQJDBQzcmEgY2VycmFkYSBkZSBjYWRpejEOMAwGA1UEEQwFMDYzNzAxCzAJBgNVBAYTAk1YMRkwFwYDVQQIDBBDSVVEQUQgREUgTUVYSUNPMREwDwYDVQQHDAhDT1lPQUNBTjERMA8GA1UELRMIMi41LjQuNDUxJTAjBgkqhkiG9w0BCQITFnJlc3BvbnNhYmxlOiBBQ0RNQS1TQVQwHhcNMTkwNjE3MTk0NDE0WhcNMjMwNjE3MTk0NDE0WjCB4jEnMCUGA1UEAxMeRVNDVUVMQSBLRU1QRVIgVVJHQVRFIFNBIERFIENWMScwJQYDVQQpEx5FU0NVRUxBIEtFTVBFUiBVUkdBVEUgU0EgREUgQ1YxJzAlBgNVBAoTHkVTQ1VFTEEgS0VNUEVSIFVSR0FURSBTQSBERSBDVjElMCMGA1UELRMcRUtVOTAwMzE3M0M5IC8gWElRQjg5MTExNlFFNDEeMBwGA1UEBRMVIC8gWElRQjg5MTExNk1HUk1aUjA1MR4wHAYDVQQLExVFc2N1ZWxhIEtlbXBlciBVcmdhdGUwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCN0peKpgfOL75iYRv1fqq+oVYsLPVUR/GibYmGKc9InHFy5lYF6OTYjnIIvmkOdRobbGlCUxORX/tLsl8Ya9gm6Yo7hHnODRBIDup3GISFzB/96R9K/MzYQOcscMIoBDARaycnLvy7FlMvO7/rlVnsSARxZRO8Kz8Zkksj2zpeYpjZIya/369+oGqQk1cTRkHo59JvJ4Tfbk/3iIyf4H/Ini9nBe9cYWo0MnKob7DDt/vsdi5tA8mMtA953LapNyCZIDCRQQlUGNgDqY9/8F5mUvVgkcczsIgGdvf9vMQPSf3jjCiKj7j6ucxl1+FwJWmbvgNmiaUR/0q4m2rm78lFAgMBAAGjHTAbMAwGA1UdEwEB/wQCMAAwCwYDVR0PBAQDAgbAMA0GCSqGSIb3DQEBCwUAA4ICAQBcpj1TjT4jiinIujIdAlFzE6kRwYJCnDG08zSp4kSnShjxADGEXH2chehKMV0FY7c4njA5eDGdA/G2OCTPvF5rpeCZP5Dw504RZkYDl2suRz+wa1sNBVpbnBJEK0fQcN3IftBwsgNFdFhUtCyw3lus1SSJbPxjLHS6FcZZ51YSeIfcNXOAuTqdimusaXq15GrSrCOkM6n2jfj2sMJYM2HXaXJ6rGTEgYmhYdwxWtil6RfZB+fGQ/H9I9WLnl4KTZUS6C9+NLHh4FPDhSk19fpS2S/56aqgFoGAkXAYt9Fy5ECaPcULIfJ1DEbsXKyRdCv3JY89+0MNkOdaDnsemS2o5Gl08zI4iYtt3L40gAZ60NPh31kVLnYNsmvfNxYyKp+AeJtDHyW9w7ftM0Hoi+BuRmcAQSKFV3pk8j51la+jrRBrAUv8blbRcQ5BiZUwJzHFEKIwTsRGoRyEx96sNnB03n6GTwjIGz92SmLdNl95r9rkvp+2m4S6q1lPuXaFg7DGBrXWC8iyqeWE2iobdwIIuXPTMVqQb12m1dAkJVRO5NdHnP/MpqOvOgLqoZBNHGyBg4Gqm4sCJHCxA1c8Elfa2RQTCk0tAzllL4vOnI1GHkGJn65xokGsaU4B4D36xh7eWrfj4/pgWHmtoDAYa8wzSwo2GVCZOs+mtEgOQB91/g==\" NoCertificado=\"30001000000400002434\" FormaPago=\"03\" Sello=\"VdFRySfT9GH2oDYN4brYezKqotuVhEvQ0dLAZaWD2q0k3djT9gbU1xLahfr636cQsd/kB59LAxunpP0gDH5r4A2mLFnNqqqfjL4vcjV5Vl2XAADaJYJo8ZC1YqIuZ60ZSr9JempEothtK0WX7Ceac5vy/bZiX1RYoGZT3tuocMIQpP6yGGf16B27E7bwD1lu2cglPNR34y1CLseuHs1UbbmlGx4cp5VT4E6ksFIOPiaMmkASeTyu5RENPn4KqFfS9IgEM7O5cdLENAfCawHK5KOhc65Dmdz9Zk+Ea49tEINIpKIA1iowMRDBaFfCJLA/w0TvEtCPZmCvzHWn0oshJw==\" Folio=\"5264\" Serie=\"A\" Version=\"3.3\" SubTotal=\"100.00\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd\" xmlns:cfdi=\"http://www.sat.gob.mx/cfd/3\">\r\n  <cfdi:Emisor Rfc=\"EKU9003173C9\" Nombre=\"ESCUELA KEMPER URGATE\" RegimenFiscal=\"601\"/>\r\n  <cfdi:Receptor Rfc=\"BAAE821009MC3\" Nombre=\"B2B TECNOLOGY\" UsoCFDI=\"G03\"/>\r\n  <cfdi:Conceptos>\r\n    <cfdi:Concepto ClaveProdServ=\"01010101\" Cantidad=\"1\" ClaveUnidad=\"E48\" Descripcion=\"PAGO EN DOLARES\" ValorUnitario=\"100\" Importe=\"100\">\r\n      <cfdi:Impuestos>\r\n        <cfdi:Traslados>\r\n          <cfdi:Traslado Base=\"100\" Impuesto=\"002\" TipoFactor=\"Tasa\" TasaOCuota=\"0.160000\" Importe=\"16.00\"/>\r\n        </cfdi:Traslados>\r\n      </cfdi:Impuestos>\r\n    </cfdi:Concepto>\r\n  </cfdi:Conceptos>\r\n  <cfdi:Impuestos TotalImpuestosTrasladados=\"16.00\">\r\n    <cfdi:Traslados>\r\n      <cfdi:Traslado Impuesto=\"002\" TipoFactor=\"Tasa\" TasaOCuota=\"0.160000\" Importe=\"16.00\"/>\r\n    </cfdi:Traslados>\r\n  </cfdi:Impuestos>\r\n  <cfdi:Complemento>\r\n    <tfd:TimbreFiscalDigital FechaTimbrado=\"2022-11-23T12:50:13\" Version=\"1.1\" UUID=\"AD566E61-1AE8-47EF-B62B-067A3DD3A35F\" RfcProvCertif=\"CRE110302L5A\" SelloCFD=\"VdFRySfT9GH2oDYN4brYezKqotuVhEvQ0dLAZaWD2q0k3djT9gbU1xLahfr636cQsd/kB59LAxunpP0gDH5r4A2mLFnNqqqfjL4vcjV5Vl2XAADaJYJo8ZC1YqIuZ60ZSr9JempEothtK0WX7Ceac5vy/bZiX1RYoGZT3tuocMIQpP6yGGf16B27E7bwD1lu2cglPNR34y1CLseuHs1UbbmlGx4cp5VT4E6ksFIOPiaMmkASeTyu5RENPn4KqFfS9IgEM7O5cdLENAfCawHK5KOhc65Dmdz9Zk+Ea49tEINIpKIA1iowMRDBaFfCJLA/w0TvEtCPZmCvzHWn0oshJw==\" NoCertificadoSAT=\"30001000000400002495\" SelloSAT=\"WvRJWqxzLIRlZNueTFsoJoLfNDjJLtoJwzHRDuSp8mB3YrNQVCpxWRk4QmgQfkpB4Kv3R3rMvgttIYwrioIOAruVYDiobr7VK5gs2yxR2HKzCqIxbpsq6jh1UBPYGJUHDnSLdoIyhFH6lOuZDT1XTx9xFPvm7VQWyZW01KNztNOwxtu7uDliYPrAEV8kTZcHmid9ZY3dEUDyJA2/GX8s/RHMVXYbdJ3Ey2cd/ARTkVW9/nQJHbqzV5U1p12yE4kr/9FcwoFjQuv1rvaATq1lyNNMYel9TpCxCTbPtwDOifnRi1l0orUfLu9oBejfVAo1BK3sDcrpqJNWi4f21qsIrw==\" xmlns:tfd=\"http://www.sat.gob.mx/TimbreFiscalDigital\" xsi:schemaLocation=\"http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/cfd/TimbreFiscalDigital/TimbreFiscalDigitalv11.xsd\" />\r\n  </cfdi:Complemento>\r\n</cfdi:Comprobante>"));
            inputMessage.cfdiState = "EMIT";
            inputMessage.isFree = false;
            inputMessage.logo64 = string.Empty;
            inputMessage.informacionAdicional = null;
            inputMessage.infoNofiscal = string.Empty;

            WS.WsFactClient wsFact = new WS.WsFactClient();

            WS.MessageRequest wsRequest = new WS.MessageRequest();

            wsRequest.xmlBase64 = inputMessage.cfdi64;
            wsRequest.apiKey = inputMessage.cfdiState;
            wsRequest.rfcEmisor = null;
            //???
            wsFact.ProcessDocument(wsRequest);


            return View(wsFact);
        }
    }
}
