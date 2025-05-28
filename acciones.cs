using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_CompraAutos
{
    internal class acciones : IACCIONES
    {
        auto a = new auto();
        private List<auto> LISTAAUTOS = new List<auto>()
        {
            new auto(1,"McLaren","Modelo Senna",2018,"Azul",750000,"No disponible"),
        };
        Correo correo = new Correo();

        public bool Actualizar(int idactu, string marcaactu, string modeloactu, int anioactu, string coloractu, double precioactu, string estadoactu)
        {
            try
            {
                var objetoeliminar = LISTAAUTOS.Find(x => x.id == idactu );
                if (objetoeliminar != null)
                {
                    LISTAAUTOS.Remove(objetoeliminar);
                    LISTAAUTOS.Add(new auto(idactu,marcaactu,modeloactu,anioactu,coloractu,precioactu,estadoactu));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool Agregar(int id, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            try
            {
                LISTAAUTOS.Add(new auto(id,marca,modelo,anio,color,precio,estado));
                return true;   
            }
            catch(Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                var autoEliminar = LISTAAUTOS.FirstOrDefault(x => x.id == id);
                if (autoEliminar != null)
                {
                    LISTAAUTOS.Remove(autoEliminar);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool ExportarExcel()
        {
            try
            {
                var rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var rutaArchivo = Path.Combine(rutaEscritorio, "Autoeseyaenelexcel.xlsx");

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Encabezados
                    worksheet.Cell(1, 1).Value = "ID";
                    worksheet.Cell(1, 2).Value = "Marca";
                    worksheet.Cell(1, 3).Value = "Modelo";
                    worksheet.Cell(1, 4).Value = "Año";
                    worksheet.Cell(1, 5).Value = "Color";
                    worksheet.Cell(1, 6).Value = "Precio";
                    worksheet.Cell(1, 7).Value = "Estado";

                    // Datos
                    for (int i = 0; i < LISTAAUTOS.Count; i++)
                    {
                        var aut = LISTAAUTOS[i];
                        worksheet.Cell(i + 2, 1).Value = aut.id;
                        worksheet.Cell(i + 2, 2).Value = aut.marca;
                        worksheet.Cell(i + 2, 3).Value = aut.modelo;
                        worksheet.Cell(i + 2, 4).Value = aut.anio;
                        worksheet.Cell(i + 2, 5).Value = aut.color;
                        worksheet.Cell(i + 2, 6).Value = aut.precio;
                        worksheet.Cell(i + 2, 7).Value = aut.estado;
                    }

                    workbook.SaveAs(rutaArchivo);
                }

                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool ImportarExcel()
        {
            try
            {
                var downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                var filePath = Path.Combine(downloadsPath, "Autos_Importacion.xlsx");

                if (!File.Exists(filePath))
                {
                    return false;
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet("Sheet1");
                    var rows = worksheet.RowsUsed().Skip(1); // Saltar encabezado

                    // Limpia la lista antes de importar por si lo quieres

                    foreach (var row in rows)
                    {
                        int id = int.Parse(row.Cell(1).GetValue<string>());
                        string marca = row.Cell(2).GetValue<string>();
                        string modelo = row.Cell(3).GetValue<string>();
                        int anio = int.Parse(row.Cell(4).GetValue<string>());
                        string color = row.Cell(5).GetValue<string>();
                        double precio = double.Parse(row.Cell(6).GetValue<string>());
                        string estado = row.Cell(7).GetValue<string>();

                        LISTAAUTOS.Add(new auto(id, marca, modelo, anio, color, precio, estado));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public List<auto> MostrarAuto()
        {
            try
            {
                return LISTAAUTOS;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public int Preciototal(double precio)
        {
            try
            {
                double sumaprecio = 0;
                foreach (var S in LISTAAUTOS)
                {
                    sumaprecio = sumaprecio + S.precio;
                }
                MessageBox.Show("La suma total es de:");
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }

            throw new NotImplementedException();
        }

        public int totalelementos(int id3, string marca3, string modelo3, int anio3, string color3, double precio3, string estado3)
        {
            try
            {
                double totalelementos = 0;
                foreach (var S in LISTAAUTOS)
                {
                    totalelementos = totalelementos + S.precio;
                }
                MessageBox.Show("El total de elementos es de:");
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
            throw new NotImplementedException();
        }
    }
}
