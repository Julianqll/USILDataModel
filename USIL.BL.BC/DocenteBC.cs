using USIL.BL.BE;
using USIL.DL.DALC;

namespace USIL.BL.BC
{
    public class DocenteBC
    {
        public List<DocenteBE> DocenteListar() {
            try
            {
                DocenteDALC objDocenteDALC = new DocenteDALC();
                return objDocenteDALC.DocenteListar();
            }
            catch (Exception ex)
            {
                return new List<DocenteBE> ();
            }
        }

        public bool DocenteInsertar(DocenteBE objDocenteBE)
        {
            try
            {
                DocenteDALC objDocenteDALC = new DocenteDALC();
                return objDocenteDALC.DocenteInsertar(objDocenteBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DocenteEditar(DocenteBE objDocenteBE)
        {
            try
            {
                DocenteDALC objDocenteDALC = new DocenteDALC();
                return objDocenteDALC.DocenteEditar(objDocenteBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DocenteEliminar(String Codigo)
        {
            try
            {
                DocenteDALC objDocenteDALC = new DocenteDALC();
                return objDocenteDALC.DocenteEliminar(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DocenteObtener(String Codigo)
        {
            try
            {
                DocenteDALC objDocenteDALC = new DocenteDALC();
                return objDocenteDALC.DocenteObtener(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}