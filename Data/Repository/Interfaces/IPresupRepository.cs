using CeroCuadrado.Entities;
using CeroCuadrado.Models.Dtos.Dtos_Creat;
using CeroCuadrado.Models.Dtos.Dtos_View;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProyectoCeroCuadrado.Entities;

namespace CeroCuadrado.Data.Repository.Interfaces
{
    public interface IPresupRepository
    {
        //Delete
        public Task DeleteCentroDeCostos(int id);
        public Task DeleteCertificados(int id);
 
        public Task DeleteEgresos(int id);
        public Task DeleteEmpresas(int id);
        public Task DeleteFormaDePago(int id);
        public Task DeleteImpuestos(int id);
 
        public Task DeleteIngresos(int id);
        public Task DeleteInsumos(int id);
        public Task DeletePlanDeCuentas(int id);
        public Task DeletePorcentajes(int id);
        public Task DeletePresupuesto(int id);
        public Task DeleteProveedores(int id);
        public Task DeleteRubros(int id);
        public Task DeleteSubRubros(int id);
        public Task DeleteTareas(int id);
        public Task DeleteTipoDeComprobante(int id);
        public Task DeleteTipoDeCosto(int id);
        public Task DeleteTipoDeOperaciones(int id);
        public Task DeleteUnidades(int id);


        ///Create
        public Task Create(CentroDeCostosDtosC dto);
        public Task Create(CertificadosDtosC dto);
 
        public Task Create(EgresosDtosC dto);
        public Task Create(EmpresasDtosC dto);
        public Task Create(FormaDePagoDtosC dto);
        public Task Create(ImpuestosDtosC dto);
 
        public Task Create(IngresosDtosC dto);
        public Task Create(InsumosDtosC dto);
        public Task Create(PlanDeCuentasDtosC dto);
        public Task Create(PorcentajesDtosC dto);
        public Task Create(PresupuestoDtosC dto);
        public Task Create(ProveedoresDtosC dto);
        public Task Create(RubrosDtosC dto);
        public Task Create(SubRubrosDtosC dto);
        public Task Create(TareasDtosC dto);
        public Task Create(TipoDeComprobanteDtosC dto);
        public Task Create(TipoDeCostoDtosC dto);
        public Task Create(TipoDeOperacionesDtosC dto);
        public Task Create(UnidadesDtosC dto);

        //Update
        public Task Update(int CentroDeCostosId, CentroDeCostosDtosV dto);
        public Task Update(int CertificadosId, CertificadosDtosV dto);
 
 
        public Task Update(int EmpresasId, EmpresasDtosV dto);
        public Task Update(int FormaDePagoId, FormaDePagoDtosV dto);
        public Task Update(int ImpuestosId, ImpuestosDtosV dto);
 
        public Task Update(int InsumosId, InsumosDtosV dto);
        public Task Update(int PlanDeCuentasId, PlanDeCuentasDtosV dto);
        public Task Update(int PorcentajesId, PorcentajesDtosV dto);
        public Task Update(int PresupuestosId, PresupuestosDtosV dto);
        public Task Update(int ProveedoresId, ProveedoresDtosV dto);
        public Task Update(int RubrosId, RubrosDtosV dto);
        public Task Update(int SubRubrosId, SubRubrosDtosV dto);
        public Task Update(int TareasId, TareasDtosV dto);
        public Task Update(int TipoDeComprobanteId, TipoDeComprobanteDtosV dto);
        public Task Update(int TipoDeCostosId, TipoDeCostosDtosV dto);
        public Task Update(int TipoDeOperacionesId, TipoDeOperacionesDtosV dto);
        public Task Update(int UnidadesId, UnidadesDtosV dto);

        //GetAll

        public Task<List<CentroDeCostos>> GetAllCentroDeCostosAsync();
        public Task<List<Certificados>> GetAllCertificadosAsync();
  
        public Task<List<Egresos>> GetAllEgresosAsync();
        public Task<List<Empresas>> GetAllEmpresasAsync();
        public Task<List<FormaDePago>> GetAllFormaDePagoAsync();
        public Task<List<Impuestos>> GetAllImpuestosAsync();
 
        public Task<List<Ingresos>> GetAllIngresosAsync();
        public Task<List<Insumos>> GetAllInsumosAsync();
        public Task<List<PlanDeCuentas>> GetAllPlanDeCuentasAsync();
        public Task<List<Porcentajes>> GetAllPorcentajesAsync();
        public Task<List<Presupuesto>> GetAllPresupuestoAsync();
        public Task<List<Proveedores>> GetAllProveedoresAsync();
        public Task<List<Rubros>> GetAllRubrosAsync();
        public Task<List<SubRubros>> GetAllSubRubrosAsync();
        public Task<List<Tareas>> GetAllTareasAsync();
        public Task<List<TipoDeComprobante>> GetAllTipoDeComprobanteAsync();
        public Task<List<TipoDeCosto>> GetAllTipoDeCostoAsync();
        public Task<List<TipoDeOperaciones>> GetAllTipoDeOperacionesAsync();
        public Task<List<Unidades>> GetAllUnidadesAsync();




    }
}
