using USIL.BL.BE;
using USIL.DL.DALC;

namespace USIL.BL.BC
{
    public class CarreraBC
    {
        public List<CarreraBE> CarreraListar() {
            try
            {
                CarreraDALC objCarreraDALC = new CarreraDALC();
                return objCarreraDALC.CarreraListar();
            }
            catch (Exception ex)
            {
                return new List<CarreraBE> ();
            }
        }

        public bool CarreraInsertar(CarreraBE objCarreraBE)
        {
            try
            {
                CarreraDALC objCarreraDALC = new CarreraDALC();
                return objCarreraDALC.CarreraInsertar(objCarreraBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CarreraEditar(CarreraBE objCarreraBE)
        {
            try
            {
                CarreraDALC objCarreraDALC = new CarreraDALC();
                return objCarreraDALC.CarreraEditar(objCarreraBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CarreraEliminar(String Codigo)
        {
            try
            {
                CarreraDALC objCarreraDALC = new CarreraDALC();
                return objCarreraDALC.CarreraEliminar(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CarreraObtener(String Codigo)
        {
            try
            {
                CarreraDALC objCarreraDALC = new CarreraDALC();
                return objCarreraDALC.CarreraObtener(Codigo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}