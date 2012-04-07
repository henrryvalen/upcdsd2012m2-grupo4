using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ventas.BE;
using Ventas.DAL;
using Ventas.DAL.EF;

namespace Ventas.BL
{
    public class AdminServiceImpl : IAdminService
    {
        #region Dependencias

        ITipoPautaDAO tipoPautaDAO = new TipoPautaDAO();
        IEmpresaDAO empresaDAO = new EmpresaDAO();
        IUsuarioDAO usuarioDAO = new UsuarioDAO();
        ITarifaDAO tarifaDAO = new TarifaDAO();
        IRadioDAO radioDAO = new RadioDAO();
        IVentaPautaDAO ventaPautaDAO = new VentaPautaDAO();

        #endregion

        #region "Tipo de Pauta"

        public ICollection<TipoPauta> ListarTipoPauta()
        {
            return tipoPautaDAO.ListarTodos();
        }

        public TipoPauta RegistrarTipoPauta(int codigoTipoPauta, string nombre, string estado)
        {
            TipoPauta beTipoPauta = new TipoPauta();
            beTipoPauta.Descripcion = nombre;
            beTipoPauta.Estado = estado;
            return tipoPautaDAO.Crear(beTipoPauta);
        }

        public TipoPauta ObtenerTipoPauta(int codigoTipoPauta)
        {
            return tipoPautaDAO.Obtener(codigoTipoPauta);
        }

        public TipoPauta ModificarTipoPauta(int codigoTipoPauta, string nombre, string estado)
        {
            TipoPauta beTipoPauta = tipoPautaDAO.Obtener(codigoTipoPauta);
            beTipoPauta.Descripcion = nombre;
            beTipoPauta.Estado = estado;
            return tipoPautaDAO.Modificar(beTipoPauta);
        }

        public void EliminarTipoPauta(int codigoTipoPauta)
        {
            TipoPauta beTipoPauta = tipoPautaDAO.Obtener(codigoTipoPauta);
            tipoPautaDAO.Eliminar(beTipoPauta);
        }

        public ICollection<TipoPauta> ListarTipoPauta(int codigoTipoPauta)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region "Empresa"

        public ICollection<Empresa> ListarEmpresa()
        {
            return empresaDAO.ListarTodos();
        }

        public Empresa RegistrarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string estado)
        {
            Empresa beEmpresa = new Empresa();
            beEmpresa.RUC = RUC;
            beEmpresa.nombrecomercial = nombrecomercial;
            beEmpresa.direccion = direccion;
            beEmpresa.telefono = telefono;
            beEmpresa.Estado = estado;

            return empresaDAO.Crear(beEmpresa);
        }

        public Empresa ObtenerEmpresa(int codigoEmpresa)
        {
            return empresaDAO.Obtener(codigoEmpresa);
        }

        public Empresa ModificarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string estado)
        {
            Empresa beEmpresa = new Empresa();
            beEmpresa.RUC = RUC;
            beEmpresa.nombrecomercial = nombrecomercial;
            beEmpresa.direccion = direccion;
            beEmpresa.telefono = telefono;
            beEmpresa.Estado = estado;

            return empresaDAO.Modificar(beEmpresa);
        }

        public void EliminarEmpresa(int codigoEmpresa)
        {
            Empresa beEmpresa = empresaDAO.Obtener(codigoEmpresa);
            empresaDAO.Eliminar(beEmpresa);
        }

        public ICollection<Empresa> ListarEmpresa(int codigoEmpresa)
        {
            throw new NotImplementedException();
        } 

        #endregion

        #region "Usuario"

        public Usuario ValidarUsuario(string usuarioUser, string usuarioPassword)
        {
            Usuario beUsuario = new Usuario();
            beUsuario.User = usuarioUser.Trim();
            beUsuario.Password = usuarioPassword.Trim();

            return usuarioDAO.ObtenerPorParametros(beUsuario);
        }

        #endregion

        #region "Tarifa"

        public ICollection<Tarifa> ListarTarifa()
        {
            return tarifaDAO.ListarTodos();
        }

        public Tarifa ObtenerTarifa(int codigoTarifa)
        {
            return tarifaDAO.Obtener(codigoTarifa);
        }

        public Tarifa RegistrarTarifa(int codigoTarifa, int codigoRadio, int CodigoTipoPauta, decimal? precio, string bloque, string estado)
        {
            Tarifa beTarifa = new Tarifa();
            beTarifa.CodigoRadio = codigoRadio;
            beTarifa.CodigoTipoPauta = CodigoTipoPauta;
            beTarifa.Precio = precio;
            beTarifa.Bloque = bloque;
            beTarifa.Estado = estado;
            return tarifaDAO.Crear(beTarifa);
        }

        public Tarifa ModificarTarifa(int codigoTarifa, int codigoRadio, int CodigoTipoPauta, decimal? precio, string bloque, string estado)
        {
            Tarifa beTarifa = tarifaDAO.Obtener(codigoTarifa);
            beTarifa.CodigoRadio = codigoRadio;
            beTarifa.CodigoTipoPauta = CodigoTipoPauta;
            beTarifa.Precio = precio;
            beTarifa.Bloque = bloque;
            beTarifa.Estado = estado;
            return tarifaDAO.Modificar(beTarifa);
        }

        public void EliminarTarifa(int codigoTarifa)
        {
            Tarifa beTarifa = tarifaDAO.Obtener(codigoTarifa);
            tarifaDAO.Eliminar(beTarifa);
        }

        #endregion

        #region "Radio"

        public ICollection<Radio> ListarRadio()
        {
            return radioDAO.ListarTodos();
        }

        #endregion

        #region "VentaPauta"


        public ICollection<VentaPauta> ListarVentaPauta()
        {
            return ventaPautaDAO.ListarTodos();
        }

        public VentaPauta ObtenerVentaPauta(int codigoVentaPauta)
        {
            return ventaPautaDAO.Obtener(codigoVentaPauta);
        }

        public VentaPauta RegistrarVentaPauta(int Codigo, int radioCodigo, string ventaNombreVendedor, string ventaDescripcionProducto, string empresaRUC, int tipoPautaCodigo, string ventaNumeroDias, int ventaPrioridad,
        int ventaTipoTransaccion, int ventaIGV, int ventaTipoOrden, decimal ventaImporteTotal, decimal ventaMontoTotal, int ventaTipoPago, DateTime ventaFechaCreacion, string ventaUsuarioCreacion, string ventaEstado)
        {
            VentaPauta beVentaPauta = new VentaPauta();

            beVentaPauta.Codigo = Codigo;
            //beVentaPauta.radioCodigo = Radio;
            beVentaPauta.ventaNombreVendedor = ventaNombreVendedor;
            beVentaPauta.ventaDescripcionProducto = ventaDescripcionProducto;
            beVentaPauta.empresaRUC = empresaRUC;
            beVentaPauta.tipoPautaCodigo = tipoPautaCodigo;
            beVentaPauta.ventaNumeroDias = ventaNumeroDias;
            beVentaPauta.ventaPrioridad = ventaPrioridad;
            beVentaPauta.ventaTipoTransaccion = ventaTipoTransaccion;
            beVentaPauta.ventaIGV = ventaIGV;
            beVentaPauta.ventaTipoOrden = ventaTipoOrden;
            beVentaPauta.ventaImporteTotal = ventaImporteTotal;
            beVentaPauta.ventaMontoTotal = ventaMontoTotal;
            beVentaPauta.ventaTipoPago = ventaTipoPago;
            beVentaPauta.ventaFechaCreacion = ventaFechaCreacion;
            beVentaPauta.ventaUsuarioCreacion = ventaUsuarioCreacion;
            beVentaPauta.ventaEstado = ventaEstado;

            //cambiarrrrrrrrr

            return ventaPautaDAO.Crear(beVentaPauta);
        }

        public VentaPauta CancelarVentaPauta(int codigoVentaPauta, string ventaUsuarioModif, DateTime ventaFechaModif)
        {
            VentaPauta beVentaPauta = new VentaPauta();
            beVentaPauta.Codigo = codigoVentaPauta;
            beVentaPauta.ventaEstado = "I";
            beVentaPauta.ventaUsuarioModif = "ADMIN";
            beVentaPauta.ventaFechaModif = DateTime.Now;
            //return ventaPautaDAO.CancelarVentaPauta(beVentaPauta);
            return null;
        }


        #endregion
    }
}


