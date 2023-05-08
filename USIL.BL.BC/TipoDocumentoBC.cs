using USIL.BL.BE;
using USIL.DL.DALC;

namespace USIL.BL.BC
{
    public class TipoDocumentoBC
    {
        public List<TipoDocumentoBE> TipoDocumentoListar() {
            try
            {
                TipoDocumentoDALC objTipoDocumentoDALC = new TipoDocumentoDALC();
                return objTipoDocumentoDALC.TipoDocumentoListar();
            }
            catch (Exception ex)
            {
                return new List<TipoDocumentoBE> ();
            }
        }

        public bool TipoDocumentoInsertar(TipoDocumentoBE objTipoDocumentoBE)
        {
            try
            {
                TipoDocumentoDALC objTipoDocumentoDALC = new TipoDocumentoDALC();
                return objTipoDocumentoDALC.TipoDocumentoInsertar(objTipoDocumentoBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool TipoDocumentoEditar(TipoDocumentoBE objTipoDocumentoBE)
        {
            try
            {
                TipoDocumentoDALC objTipoDocumentoDALC = new TipoDocumentoDALC();
                return objTipoDocumentoDALC.TipoDocumentoEditar(objTipoDocumentoBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool TipoDocumentoEliminar(String Codigo)
        {
            try
            {
                TipoDocumentoDALC objTipoDocumentoDALC = new TipoDocumentoDALC();
                return objTipoDocumentoDALC.TipoDocumentoEliminar(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool TipoDocumentoObtener(String Codigo)
        {
            try
            {
                TipoDocumentoDALC objTipoDocumentoDALC = new TipoDocumentoDALC();
                return objTipoDocumentoDALC.TipoDocumentoObtener(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}