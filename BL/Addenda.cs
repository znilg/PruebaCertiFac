using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Addenda
    {
        public static ML.Result Add(ML.Addenda addenda) //AGREGAR POR EF
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Cer_AddendasEntities context = new DL.Cer_AddendasEntities())
                {
                    context.Addendas.Add(addenda);
                    var query = context.SaveChanges();
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "COMPRUEBA LOS DATOS";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Update(ML.Addenda addenda)  //ACTUALIZAR POR EF
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Cer_AddendasEntities context = new DL.Cer_AddendasEntities())
                {
                    ML.Addenda addendaForUpd = context.Addendas.Where(x => x.IdAddenda == addenda.IdAddenda).FirstOrDefault();

                    addendaForUpd = addenda;

                    var query = context.SaveChanges();

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "ERROR AL ACTUALIZAR";

                    }
                }
                result.Correct = true;
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Delete(int IdAddenda)  //ELIMINAR POR EF
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Cer_AddendasEntities context = new DL.Cer_AddendasEntities())
                {
                    ML.Addenda addendaForUpd = context.Addendas.Where(x => x.IdAddenda == IdAddenda).FirstOrDefault();

                    addendaForUpd.Estado = false;

                    var query = context.SaveChanges();

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "ERROR AL ELIMINAR";
                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result GetAll()  //GETALL POR EF
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Cer_AddendasEntities context = new DL.Cer_AddendasEntities())
                {
                    var query = context.Addendas;

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var lista in query)
                        {
                            ML.Addenda addenda = new ML.Addenda();

                            addenda.IdAddenda = lista.IdAddenda;
                            addenda.NombreAddenda = lista.NombreAddenda;
                            addenda.FechaModificacion = lista.FechaModificacion;
                            addenda.XML = lista.XML;
                            addenda.Estado = lista.Estado;

                            result.Objects.Add(addenda);
                        }

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "NO SE ENCONTRARON REGISTROS";
                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result GetByIdEF(int IdAddenda)  //GetById POR EF
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.Cer_AddendasEntities context = new DL.Cer_AddendasEntities())
                {
                    var query = context.Addendas.Where(x => x.IdAddenda == IdAddenda).FirstOrDefault();

                    if (query != null)
                    {
                        ML.Addenda addenda = new ML.Addenda();

                        addenda.IdAddenda = query.IdAddenda;
                        addenda.NombreAddenda = query.NombreAddenda;
                        addenda.FechaModificacion = query.FechaModificacion;
                        addenda.XML = query.XML;
                        addenda.Estado = query.Estado;

                        result.Object = addenda;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "NO SE ENCONTRARO EL REGISTRO";
                    }

                }
                return result;
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }
    }
}
