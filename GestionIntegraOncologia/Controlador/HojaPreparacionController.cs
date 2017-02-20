using DataAccess;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class HojaPreparacionController
    {
        private HojaPreparacionDA objHojaPreparacion = null;
        private PacienteDA objPaciente = null;
        private MaterialDA objMaterial = null;
        private static readonly log4net.ILog log =
log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public HojaPreparacionController()
        {
            objHojaPreparacion = new HojaPreparacionDA();
        }
        public List<HojaPreparacionEntity> GetHojasPreparacion()
        {
            return objHojaPreparacion.GetHojaPreparacion();
        }
        public void DeleteHojaPreparacion(int id)
        {
            objHojaPreparacion.DeleteHojaPreparacion(id);
        }
        public HojaPreparacion FindbyID(int id)
        {
            return objHojaPreparacion.FindbyID(id);
        }
        public void CreateHojaPreparacion(HojaPreparacion objC)
        {
            objHojaPreparacion.CreateHojaPreparacion(objC);
        }
        public void UpdateHojaPreparacion(HojaPreparacion objC)
        {
            objHojaPreparacion.UpdateHojaPreparacion(objC);
        }

        public double optimizarPreparado(int edad, double peso, String estado, int idPaciente)
        {
            double dosisOptimizada = 0.0;

            try
            {
                int indiceEstadoPaciente = calcularIndiceEstadoPaciente(estado);
                double indiceEdad = calcularIndiceEdad(edad);
                double indicePeso = calcularIndicePeso(peso);

                double indiceBase = indiceEstadoPaciente * indiceEdad * indicePeso;
                double gradoToxicidadPermitido = calcularGradoToxicidadMax(indiceBase);
                MaterialxPreparado materialxpreparado = objHojaPreparacion.obtenerMateriales(idPaciente);

                dosisOptimizada = gradoToxicidadPermitido * materialxpreparado.Dosis;
            }catch (Exception ex)
            {
                log.Info("Excepcion: "+ex);
            }
 
            return dosisOptimizada;

        }

        public Material getMaterialxPreparado(int idPaciente)
        {

            MaterialxPreparado materialxpreparado = objHojaPreparacion.obtenerMateriales(idPaciente);
            Material material = new Material();
            objMaterial = new MaterialDA();
            material = objMaterial.FindbyID(materialxpreparado.IDMaterial);
            return material;
        }

        private int calcularIndiceEstadoPaciente(String estado)
        {
            int indice = 0;
            switch (estado)
            {
                case "Optimo":
                    indice = 1;
                    break;

                case "Muy Bueno":
                    indice = 2;
                    break;

                case "Bueno":
                    indice = 3;
                    break;

                case "Regular":
                    indice = 4;
                    break;

            }
            return indice;
        }

        private double calcularIndiceEdad(int edad)
        {
            double indice = 0.0;
            if (edad >= 18 && edad <= 25)
            {
                indice = 1;
            }
            else if (edad >= 26 && edad <= 29)
            {
                indice = 1.3;
            }
            else if (edad >= 30 && edad <= 35)
            {
                indice = 1.5;
            }
            else if (edad >= 36 && edad <= 38)
            {
                indice = 1.6;
            }
            else if (edad >= 39 && edad <= 43)
            {
                indice = 1.8;
            }
            else if (edad >= 44 && edad <= 46)
            {
                indice = 2;
            }
            else if (edad >= 47 && edad <= 50)
            {
                indice = 2.5;
            }
            else if (edad >= 51 && edad <= 54)
            {
                indice = 2.9;
            }
            else if (edad >= 55 && edad <= 60)
            {
                indice = 3.4;
            }
            else if (edad >= 61 && edad <= 64)
            {
                indice = 3.9;
            }
            else if (edad >= 64 && edad <= 68)
            {
                indice = 4.7;
            }
            else if (edad > 68)
            {
                indice = 5.5;
            }
            return indice;
        }


        private double calcularIndicePeso(double peso)
        {
            double indice = 0.0;
            if (peso <= 40)
            {
                indice = 4.6;
            }
            else if (peso >= 41 && peso <= 45)
            {
                indice = 4.2;
            }
            else if (peso >= 46 && peso <= 49)
            {
                indice = 3.5;
            }
            else if (peso >= 50 && peso <= 54)
            {
                indice = 3;
            }
            else if (peso >= 55 && peso <= 60)
            {
                indice = 2.5;
            }
            else if (peso >= 61 && peso <= 70)
            {
                indice = 2;
            }
            else if (peso >= 70 && peso <= 80)
            {
                indice = 1.8;
            }
            else if (peso >= 80 && peso <= 85)
            {
                indice = 2.1;
            }
            else if (peso >= 86 && peso <= 90)
            {
                indice = 3;
            }
            else if (peso >= 92 )
            {
                indice = 3.5;
            }
            return indice;
        }

        private double calcularGradoToxicidadMax(double indiceBase)
        {
            double gradoToxicidad = 0.0;
            if (indiceBase >= 1.8 && indiceBase <= 3.8)
            {
                gradoToxicidad = 1;
            }
            else if (indiceBase >= 3.9 && indiceBase <= 7.9)
            {
                gradoToxicidad = 0.99;
            }
            else if (indiceBase >= 8.0 && indiceBase <= 13.0)
            {
                gradoToxicidad = 0.98;
            }
            else if (indiceBase >= 13.1 && indiceBase <= 18.2)
            {
                gradoToxicidad = 0.95;
            }
            else if (indiceBase >= 18.3 && indiceBase <= 23.3)
            {
                gradoToxicidad = 0.93;
            }
            else if (indiceBase >= 23.4 && indiceBase <= 30.3)
            {
                gradoToxicidad = 0.92;
            }
            else if (indiceBase >= 30.4 && indiceBase <= 37.4)
            {
                gradoToxicidad = 0.90;
            }
            else if (indiceBase >= 37.5 && indiceBase <= 44.6)
            {
                gradoToxicidad = 0.89;
            }
            else if (indiceBase >= 44.6 && indiceBase <= 52.6)
            {
                gradoToxicidad = 0.86;
            }
            else if (indiceBase >= 52.7 && indiceBase <= 61.7)
            {
                gradoToxicidad = 0.83;
            }
            else if (indiceBase >= 61.8 && indiceBase <= 71.8)
            {
                gradoToxicidad = 0.80;
            }
            else if (indiceBase >= 71.9 && indiceBase <= 87.8)
            {
                gradoToxicidad = 0.77;
            }
            else if (indiceBase >= 87.9 && indiceBase <= 103.9)
            {
                gradoToxicidad = 0.73;
            }
            else if (indiceBase >= 104.0 && indiceBase <= 115.0)
            {
                gradoToxicidad = 0.70;
            }
            else if (indiceBase > 115.0)
            {
                gradoToxicidad = 0;
            }
            return gradoToxicidad;
        }

    }
}
