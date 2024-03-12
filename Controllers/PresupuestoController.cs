using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using CeroCuadrado.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using ProyectoCeroCuadrado.Entities;
using CeroCuadrado.Models.Dtos.Dtos_Creat;
using CeroCuadrado.Models.Dtos.Dtos_View;


namespace CeroCuadrado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPresupRepository _presupRepository;
        private readonly IConfiguration _config;

        public PresupuestoController(IConfiguration config, IMapper mapper, IPresupRepository presupRepository)
        {
            _config = config;
            _mapper = mapper;
            _presupRepository = presupRepository;

        }
        ///      get all de todos

        [HttpGet]
        [Route("GetAllCentroDeCostos")]
        public async Task<IActionResult> GetAllCentroDeCostosAsync()
        {
            try
            {
                var CentroDeCostos = await _presupRepository.GetAllCentroDeCostosAsync();
                return Ok(CentroDeCostos);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllCertificados")]
        public async Task<IActionResult> GetAllCertificadosAsync()
        {
            try
            {
                var Certificados = await _presupRepository.GetAllCertificadosAsync();
                return Ok(Certificados);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllEgresos")]
        public async Task<IActionResult> GetAllEgresosAsync()
        {
            try
            {
                var Egresos = await _presupRepository.GetAllEgresosAsync();
                return Ok(Egresos);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllEmpresas")]
        public async Task<IActionResult> GetAllEmpresasAsync()
        {
            try
            {
                var Empresas = await _presupRepository.GetAllEmpresasAsync();
                return Ok(Empresas);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllFormaDePago")]
        public async Task<IActionResult> GetAllFormaDePagoAsync()
        {
            try
            {
                var FormaDePago = await _presupRepository.GetAllFormaDePagoAsync();
                return Ok(FormaDePago);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllImpuestos")]
        public async Task<IActionResult> GetAllImpuestosAsync()
        {
            try
            {
                var Impuestos = await _presupRepository.GetAllImpuestosAsync();
                return Ok(Impuestos);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllIngresos")]
        public async Task<IActionResult> GetAllIngresosAsync()
        {
            try
            {
                var Ingresos = await _presupRepository.GetAllIngresosAsync();
                return Ok(Ingresos);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllInsumos")]
        public async Task<IActionResult> GetAllInsumosAsync()
        {
            try
            {
                var Insumos = await _presupRepository.GetAllInsumosAsync();
                return Ok(Insumos);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllPlanDeCuentas")]
        public async Task<IActionResult> GetAllPlanDeCuentasAsync()
        {
            try
            {
                var PlanDeCuentas = await _presupRepository.GetAllPlanDeCuentasAsync();
                return Ok(PlanDeCuentas);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllPorcentajes")]
        public async Task<IActionResult> GetAllPorcentajesAsync()
        {
            try
            {
                var Porcentajes = await _presupRepository.GetAllPorcentajesAsync();
                return Ok(Porcentajes);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllPresupuesto")]
        public async Task<IActionResult> GetAllPresupuestoAsync()
        {
            try
            {
                var Presupuesto = await _presupRepository.GetAllPresupuestoAsync();
                return Ok(Presupuesto);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllProveedores")]
        public async Task<IActionResult> GetAllProveedoresAsync()
        {
            try
            {
                var Proveedores = await _presupRepository.GetAllProveedoresAsync();
                return Ok(Proveedores);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllRubros")]
        public async Task<IActionResult> GetAllRubrosAsync()
        {
            try
            {
                var Rubros = await _presupRepository.GetAllRubrosAsync();
                return Ok(Rubros);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllSubRubros")]
        public async Task<IActionResult> GetAllSubRubrosAsync()
        {
            try
            {
                var SubRubros = await _presupRepository.GetAllSubRubrosAsync();
                return Ok(SubRubros);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllTareas")]
        public async Task<IActionResult> GetAllTareasAsync()
        {
            try
            {
                var Tareas = await _presupRepository.GetAllTareasAsync();
                return Ok(Tareas);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllTipoDeComprobante")]
        public async Task<IActionResult> GetAllTipoDeComprobanteAsync()
        {
            try
            {
                var TipoDeComprobante = await _presupRepository.GetAllTipoDeComprobanteAsync();
                return Ok(TipoDeComprobante);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllTipoDeCosto")]
        public async Task<IActionResult> GetAllTipoDeCostoAsync()
        {
            try
            {
                var TipoDeCosto = await _presupRepository.GetAllTipoDeCostoAsync();
                return Ok(TipoDeCosto);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllTipoDeOperaciones")]
        public async Task<IActionResult> GetAllTipoDeOperacionesAsync()
        {
            try
            {
                var TipoDeOperaciones = await _presupRepository.GetAllTipoDeOperacionesAsync();
                return Ok(TipoDeOperaciones);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("GetAllUnidades")]
        public async Task<IActionResult> GetAllUnidadesAsync()
        {
            try
            {
                var Unidades = await _presupRepository.GetAllUnidadesAsync();
                return Ok(Unidades);
            }
            catch (Exception ex)
            {

                return BadRequest($"Error: {ex.Message}");
            }

        }

        //Create alls//////////////////////////////////////////////////////////////////////

        [HttpPost]
        [Route("CentroDeCostos")]

        public async Task<IActionResult> Create(CentroDeCostosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Certificados")]

        public async Task<IActionResult> Create(CertificadosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Egresos")]

        public async Task<IActionResult> Create(EgresosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Empresas")]

        public async Task<IActionResult> Create(EmpresasDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("FormaDePago")]

        public async Task<IActionResult> Create(FormaDePagoDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Impuestos")]

        public async Task<IActionResult> Create(ImpuestosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Ingresos")]

        public async Task<IActionResult> Create(IngresosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Insumos")]

        public async Task<IActionResult> Create(InsumosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("PlanDeCuentas")]

        public async Task<IActionResult> Create(PlanDeCuentasDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Porcentajes")]

        public async Task<IActionResult> Create(PorcentajesDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Presupuesto")]

        public async Task<IActionResult> Create(PresupuestoDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Proveedores")]

        public async Task<IActionResult> Create(ProveedoresDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Rubros")]

        public async Task<IActionResult> Create(RubrosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("SubRubros")]

        public async Task<IActionResult> Create(SubRubrosDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Tareas")]

        public async Task<IActionResult> Create(TareasDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("TipoDeComprobante")]

        public async Task<IActionResult> Create(TipoDeComprobanteDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("TipoDeCosto")]

        public async Task<IActionResult> Create(TipoDeCostoDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("TipoDeOperaciones")]

        public async Task<IActionResult> Create(TipoDeOperacionesDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        [Route("Unidades")]

        public async Task<IActionResult> Create(UnidadesDtosC dto)
        {
            try
            {
                await _presupRepository.Create(dto);
                return Created("Created", dto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

        }
        //UpDate All//////////////////////////////////////////////////////////////////////////

        [HttpPut]
        [Route("CentroDeCostosUpDate")]
        public async Task<IActionResult> Update(int CentroDeCostosId, CentroDeCostosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(CentroDeCostosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("CertificadosUpDate")]
        public async Task<IActionResult> Update(int CertificadosId, CertificadosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(CertificadosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPut]
        [Route("EmpresaUpDate")]
        public async Task<IActionResult> Update(int EmpresasId, EmpresasDtosV dto)
        {
            try
            {
                await _presupRepository.Update(EmpresasId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("FormaDePagoUpDate")]
        public async Task<IActionResult> Update(int FormaDePagoId, FormaDePagoDtosV dto)
        {
            try
            {
                await _presupRepository.Update(FormaDePagoId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("ImpuestosUpDate")]
        public async Task<IActionResult> Update(int ImpuestosId, ImpuestosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(ImpuestosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("InsumosUpDate")]
        public async Task<IActionResult> Update(int InsumosId, InsumosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(InsumosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("PlanDeCuentasUpDate")]
        public async Task<IActionResult> Update(int PlanDeCuentasId, PlanDeCuentasDtosV dto)
        {
            try
            {
                await _presupRepository.Update(PlanDeCuentasId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("PorcentajesUpDate")]
        public async Task<IActionResult> Update(int PorcentajesId, PorcentajesDtosV dto)
        {
            try
            {
                await _presupRepository.Update(PorcentajesId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("PresupuestosUpDate")]
        public async Task<IActionResult> Update(int PresupuestosId, PresupuestosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(PresupuestosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("ProveedoresUpDate")]
        public async Task<IActionResult> Update(int ProveedoresId, ProveedoresDtosV dto)
        {
            try
            {
                await _presupRepository.Update(ProveedoresId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("RubrosUpDate")]
        public async Task<IActionResult> Update(int RubrosId, RubrosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(RubrosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("SubRubrosUpDate")]
        public async Task<IActionResult> Update(int SubRubrosId, SubRubrosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(SubRubrosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("TareasUpDate")]
        public async Task<IActionResult> Update(int TareasId, TareasDtosV dto)
        {
            try
            {
                await _presupRepository.Update(TareasId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("TipoDeComprobanteUpDate")]
        public async Task<IActionResult> Update(int TipoDeComprobanteId, TipoDeComprobanteDtosV dto)
        {
            try
            {
                await _presupRepository.Update(TipoDeComprobanteId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("TipoDeCostosUpDate")]
        public async Task<IActionResult> Update(int TipoDeCostosId, TipoDeCostosDtosV dto)
        {
            try
            {
                await _presupRepository.Update(TipoDeCostosId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("TipoDeOperacionesUpDate")]
        public async Task<IActionResult> Update(int TipoDeOperacionesId, TipoDeOperacionesDtosV dto)
        {
            try
            {
                await _presupRepository.Update(TipoDeOperacionesId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("UnidadesUpDate")]
        public async Task<IActionResult> Update(int UnidadesId, UnidadesDtosV dto)
        {
            try
            {
                await _presupRepository.Update(UnidadesId, dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //DELETE ALL ////////////////////////////////////////////////////////////////////////////////
        [HttpDelete]
        [Route("DeletCentroDeCostos")]
        public async Task<IActionResult> DeleteCentroDeCostos(int id)
        {
            try
            {
                await _presupRepository.DeleteCentroDeCostos(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteCertificados")]
        public async Task<IActionResult> DeleteCertificados(int id)
        {
            try
            {
                await _presupRepository.DeleteCertificados(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteEgresos")]
        public async Task<IActionResult> DeleteCentroDeCoDeleteEgresosstos(int id)
        {
            try
            {
                await _presupRepository.DeleteEgresos(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteEmpresas")]
        public async Task<IActionResult> DeleteEmpresas(int id)
        {
            try
            {
                await _presupRepository.DeleteEmpresas(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteFormaDePago")]
        public async Task<IActionResult> DeleteFormaDePago(int id)
        {
            try
            {
                await _presupRepository.DeleteFormaDePago(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteImpuestos")]
        public async Task<IActionResult> DeleteImpuestos(int id)
        {
            try
            {
                await _presupRepository.DeleteImpuestos(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteIngresos")]
        public async Task<IActionResult> DeleteIngresos(int id)
        {
            try
            {
                await _presupRepository.DeleteIngresos(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteInsumos")]
        public async Task<IActionResult> DeleteInsumos(int id)
        {
            try
            {
                await _presupRepository.DeleteInsumos(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeletePlanDeCuentas")]
        public async Task<IActionResult> DeletePlanDeCuentas(int id)
        {
            try
            {
                await _presupRepository.DeletePlanDeCuentas(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeletePorcentajes")]
        public async Task<IActionResult> DeletePorcentajes(int id)
        {
            try
            {
                await _presupRepository.DeletePorcentajes(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeletePresupuesto")]
        public async Task<IActionResult> DeletePresupuesto(int id)
        {
            try
            {
                await _presupRepository.DeletePresupuesto(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteProveedores")]
        public async Task<IActionResult> DeleteProveedores(int id)
        {
            try
            {
                await _presupRepository.DeleteProveedores(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteRubros")]
        public async Task<IActionResult> DeleteRubros(int id)
        {
            try
            {
                await _presupRepository.DeleteRubros(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteSubRubros")]
        public async Task<IActionResult> DeleteSubRubros(int id)
        {
            try
            {
                await _presupRepository.DeleteSubRubros(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteTareas")]
        public async Task<IActionResult> DeleteTareas(int id)
        {
            try
            {
                await _presupRepository.DeleteTareas(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteTipoDeComprobante")]
        public async Task<IActionResult> DeleteTipoDeComprobante(int id)
        {
            try
            {
                await _presupRepository.DeleteTipoDeComprobante(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteTipoDeCosto")]
        public async Task<IActionResult> DeleteTipoDeCosto(int id)
        {
            try
            {
                await _presupRepository.DeleteTipoDeCosto(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteTipoDeOperaciones")]
        public async Task<IActionResult> DeleteTipoDeOperaciones(int id)
        {
            try
            {
                await _presupRepository.DeleteTipoDeOperaciones(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteUnidades")]
        public async Task<IActionResult> DeleteUnidades(int id)
        {
            try
            {
                await _presupRepository.DeleteUnidades(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }






    }
}
