using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Library.Code.Utilities.IBase
{
    public interface IImpresoraTicket
    {
        //string GetConfiguracionTicket();
        string lineasGuion();
        string lineasGuionBajo();
        string lineasIgual();
        string lineasAsteriscos();
        void EncabezadoVenta();
        void TextoIzquierda(string texto);
        void TextDerecha(string texto);
        void TextoCentro(string texto);
        void TextoExtremos(string textoIzquierda, string textoDerecho);
        void AgregarTotales(string texto, decimal total);
        void AgregarEnteros(string texto, int cantidad);
        void AgregarArticulos(string articulo, int cant, decimal precio, decimal importe);
        void CortaTicket();
        void AbreCajon();
        void ImprimirTicket(string impresora);
        void SaltosDeLineaTicket(int numeroLineas);

        void AgregarArticulosPromocion(string articulo, string cant, string precio, string importe);
        /*
        void ImprimeTiquet(int opcion);
        void Document_PrintPage(object sender, PrintPageEventArgs e);
        void diseñoDatos(ref Graphics h, SolidBrush brush, PageSettings ps);
        */
    }
}
