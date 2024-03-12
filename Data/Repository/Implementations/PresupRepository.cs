using CeroCuadrado.Data.Repository.Interfaces;
using CeroCuadrado.Entities;
using AutoMapper;
using CeroCuadrado.Models.Dtos.Dtos_Creat;
using Microsoft.EntityFrameworkCore;
using System;
using ProyectoCeroCuadrado.Entities;
using CeroCuadrado.Models.Dtos.Dtos_View;






namespace CeroCuadrado.Data.Repository.Implementations

{
    public class PresupRepository : IPresupRepository
    {
        private readonly PresupuestoContext _context;
        private readonly IMapper _mapper;

        public PresupRepository(PresupuestoContext context, IMapper autoMapper)
        {
            _context = context;
            _mapper = autoMapper;
        }
        //Deletes

        public async Task DeleteCentroDeCostos(int id)
        {
            var CentroDeCostosToDelete = await _context.CentroDeCostos.SingleOrDefaultAsync(c => c.Id == id);

            if (CentroDeCostosToDelete != null)
            {
                _context.CentroDeCostos.Remove(CentroDeCostosToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteCertificados(int id)
        {
            var CertificadosToDelete = await _context.Certificados.SingleOrDefaultAsync(c => c.Id == id);

            if (CertificadosToDelete != null)
            {
                _context.Certificados.Remove(CertificadosToDelete);
                await _context.SaveChangesAsync();
            }
        }
 
        public async Task DeleteEgresos(int id)
        {
            var EgresosToDelete = await _context.Egresos.SingleOrDefaultAsync(c => c.Id == id);

            if (EgresosToDelete != null)
            {
                _context.Egresos.Remove(EgresosToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteEmpresas(int id)
        {
            var EmpresasToDelete = await _context.Empresas.SingleOrDefaultAsync(c => c.Id == id);

            if (EmpresasToDelete != null)
            {
                _context.Empresas.Remove(EmpresasToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteFormaDePago(int id)
        {
            var FormaDePagoToDelete = await _context.FormaDePago.SingleOrDefaultAsync(c => c.Id == id);

            if (FormaDePagoToDelete != null)
            {
                _context.FormaDePago.Remove(FormaDePagoToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteImpuestos(int id)
        {
            var ImpuestosToDelete = await _context.Impuestos.SingleOrDefaultAsync(c => c.Id == id);

            if (ImpuestosToDelete != null)
            {
                _context.Impuestos.Remove(ImpuestosToDelete);
                await _context.SaveChangesAsync();
            }
        }
 
        public async Task DeleteIngresos(int id)
        {
            var IngresosToDelete = await _context.Ingresos.SingleOrDefaultAsync(c => c.Id == id);

            if (IngresosToDelete != null)
            {
                _context.Ingresos.Remove(IngresosToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteInsumos(int id)
        {
            var InsumosToDelete = await _context.Insumos.SingleOrDefaultAsync(c => c.Id == id);

            if (InsumosToDelete != null)
            {
                _context.Insumos.Remove(InsumosToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeletePlanDeCuentas(int id)
        {
            var PlanDeCuentasToDelete = await _context.PlanDeCuentas.SingleOrDefaultAsync(c => c.Id == id);

            if (PlanDeCuentasToDelete != null)
            {
                _context.PlanDeCuentas.Remove(PlanDeCuentasToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeletePorcentajes(int id)
        {
            var PorcentajesToDelete = await _context.Porcentajes.SingleOrDefaultAsync(c => c.Id == id);

            if (PorcentajesToDelete != null)
            {
                _context.Porcentajes.Remove(PorcentajesToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeletePresupuesto(int id)
        {
            var PresupuestosToDelete = await _context.Presupuestos.SingleOrDefaultAsync(c => c.Id == id);

            if (PresupuestosToDelete != null)
            {
                _context.Presupuestos.Remove(PresupuestosToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteProveedores(int id)
        {
            var ProveedoresToDelete = await _context.Proveedores.SingleOrDefaultAsync(c => c.Id == id);

            if (ProveedoresToDelete != null)
            {
                _context.Proveedores.Remove(ProveedoresToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteRubros(int id)
        {
            var rubroToDelete = await _context.Rubros.SingleOrDefaultAsync(c => c.Id == id);

            if (rubroToDelete != null)
            {
                _context.Rubros.Remove(rubroToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteSubRubros(int id)
        {
            var SubRubrosToDelete = await _context.SubRubros.SingleOrDefaultAsync(c => c.Id == id);

            if (SubRubrosToDelete != null)
            {
                _context.SubRubros.Remove(SubRubrosToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteTareas(int id)
        {
            var TareasToDelete = await _context.Tareas.SingleOrDefaultAsync(c => c.Id == id);

            if (TareasToDelete != null)
            {
                _context.Tareas.Remove(TareasToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteTipoDeComprobante(int id)
        {
            var TipoDeComprobantesToDelete = await _context.TipoDeComprobantes.SingleOrDefaultAsync(c => c.Id == id);

            if (TipoDeComprobantesToDelete != null)
            {
                _context.TipoDeComprobantes.Remove(TipoDeComprobantesToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteTipoDeCosto(int id)
        {
            var TipoDeCostoToDelete = await _context.TipoDeCosto.SingleOrDefaultAsync(c => c.Id == id);

            if (TipoDeCostoToDelete != null)
            {
                _context.TipoDeCosto.Remove(TipoDeCostoToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteTipoDeOperaciones(int id)
        {
            var TipoDeOperacionesToDelete = await _context.TipoDeOperaciones.SingleOrDefaultAsync(c => c.Id == id);

            if (TipoDeOperacionesToDelete != null)
            {
                _context.TipoDeOperaciones.Remove(TipoDeOperacionesToDelete);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteUnidades(int id)
        {
            var UnidadesToDelete = await _context.Unidades.SingleOrDefaultAsync(c => c.Id == id);

            if (UnidadesToDelete != null)
            {
                _context.Unidades.Remove(UnidadesToDelete);
                await _context.SaveChangesAsync();
            }
        }



        //implementaciones de creacion de todas las entidades
        public async Task Create(CentroDeCostosDtosC dto)
        {
            var centroDeCostos = _mapper.Map<CentroDeCostos>(dto);
            _context.CentroDeCostos.Add(centroDeCostos);
            await _context.SaveChangesAsync();
        }
        public async Task Create(CertificadosDtosC dto)
        {
            var Certificados = _mapper.Map<Certificados>(dto);
            _context.Certificados.Add(Certificados);
            await _context.SaveChangesAsync();
        }
 
        public async Task Create(EgresosDtosC dto)
        {
            var Egresos = _mapper.Map<Egresos>(dto);
            _context.Egresos.Add(Egresos);
            await _context.SaveChangesAsync();
        }
        public async Task Create(EmpresasDtosC dto)
        {
            var Empresas = _mapper.Map<Empresas>(dto);
            _context.Empresas.Add(Empresas);
            await _context.SaveChangesAsync();
        }
        public async Task Create(FormaDePagoDtosC dto)
        {
            var FormaDePago = _mapper.Map<FormaDePago>(dto);
            _context.FormaDePago.Add(FormaDePago);
            await _context.SaveChangesAsync();
        }
        public async Task Create(ImpuestosDtosC dto)
        {
            var Impuestos = _mapper.Map<Impuestos>(dto);
            _context.Impuestos.Add(Impuestos);
            await _context.SaveChangesAsync();
        }
 
        public async Task Create(IngresosDtosC dto)
        {
            var Ingresos = _mapper.Map<Ingresos>(dto);
            _context.Ingresos.Add(Ingresos);
            await _context.SaveChangesAsync();
        }
        public async Task Create(InsumosDtosC dto)
        {
            var Insumos = _mapper.Map<Insumos>(dto);
            _context.Insumos.Add(Insumos);
            await _context.SaveChangesAsync();
        }
        public async Task Create(PlanDeCuentasDtosC dto)
        {
            var PlanDeCuentas = _mapper.Map<PlanDeCuentas>(dto);
            _context.PlanDeCuentas.Add(PlanDeCuentas);
            await _context.SaveChangesAsync();
        }
        public async Task Create(PorcentajesDtosC dto)
        {
            var Porcentajes = _mapper.Map<Porcentajes>(dto);
            _context.Porcentajes.Add(Porcentajes);
            await _context.SaveChangesAsync();
        }
        public async Task Create(PresupuestoDtosC dto)
        {
            var Presupuesto = _mapper.Map<Presupuesto>(dto);
            _context.Presupuestos.Add(Presupuesto);
            await _context.SaveChangesAsync();
        }
        public async Task Create(ProveedoresDtosC dto)
        {
            var Proveedores = _mapper.Map<Proveedores>(dto);
            _context.Proveedores.Add(Proveedores);
            await _context.SaveChangesAsync();
        }
        public async Task Create(RubrosDtosC dto)
        {
            var Rubros = _mapper.Map<Rubros>(dto);
            _context.Rubros.Add(Rubros);
            await _context.SaveChangesAsync();
        }
        public async Task Create(SubRubrosDtosC dto)
        {
            var SubRubros = _mapper.Map<SubRubros>(dto);
            _context.SubRubros.Add(SubRubros);
            await _context.SaveChangesAsync();
        }
        public async Task Create(TareasDtosC dto)
        {
            var Tareas = _mapper.Map<Tareas>(dto);
            _context.Tareas.Add(Tareas);
            await _context.SaveChangesAsync();
        }
        public async Task Create(TipoDeComprobanteDtosC dto)
        {
            var TipoDeComprobante = _mapper.Map<TipoDeComprobante>(dto);
            _context.TipoDeComprobantes.Add(TipoDeComprobante);
            await _context.SaveChangesAsync();
        }
        public async Task Create(TipoDeCostoDtosC dto)
        {
            var TipoDeCosto = _mapper.Map<TipoDeCosto>(dto);
            _context.TipoDeCosto.Add(TipoDeCosto);
            await _context.SaveChangesAsync();
        }
        public async Task Create(TipoDeOperacionesDtosC dto)
        {
            var TipoDeOperaciones = _mapper.Map<TipoDeOperaciones>(dto);
            _context.TipoDeOperaciones.Add(TipoDeOperaciones);
            await _context.SaveChangesAsync();
        }
        public async Task Create(UnidadesDtosC dto)
        {
            var Unidades = _mapper.Map<Unidades>(dto);
            _context.Unidades.Add(Unidades);
            await _context.SaveChangesAsync();
        }


        //implementaciones de Update de todas las entidades
        public async Task Update(int CentroDeCostosId, CentroDeCostosDtosV dto)

        {
            int CentroDeCostos_Id = CentroDeCostosId;
            var CentroDeCostoItem = await _context.CentroDeCostos.FirstOrDefaultAsync(c => c.Id == CentroDeCostos_Id);

            if (CentroDeCostos_Id != null)

            {
                var CentroDeCostos_map = _mapper.Map<CentroDeCostos>(dto);
                CentroDeCostoItem.Name = CentroDeCostos_map.Name;
                CentroDeCostoItem.ModifiedDate = DateTime.Now;


                await _context.SaveChangesAsync();

            }

        }
        public async Task Update(int CertificadosId, CertificadosDtosV dto)
        {
            int Certificados_Id = CertificadosId;
            var CertificadosItem = await _context.Certificados.FirstOrDefaultAsync(c => c.Id == Certificados_Id);

            if (CertificadosItem != null)
            {
                var Certificados_map = _mapper.Map<Certificados>(dto);
                CertificadosItem.Name = Certificados_map.Name;
                CertificadosItem.Month = Certificados_map.Month;
                CertificadosItem.Week = Certificados_map.Week;
                CertificadosItem.Week2 = Certificados_map.Week2;
                CertificadosItem.Week3 = Certificados_map.Week3;
                CertificadosItem.Week4 = Certificados_map.Week4;
                CertificadosItem.Week5 = Certificados_map.Week5;
                CertificadosItem.TotalValue = Certificados_map.TotalValue;


                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(int EmpresasId, EmpresasDtosV dto)
        {
            int Empresas_Id = EmpresasId;
            var EmpresasItem = await _context.Empresas.FirstOrDefaultAsync(c => c.Id == Empresas_Id);

            if (EmpresasItem != null)
            {
                var Empresas_map = _mapper.Map<Empresas>(dto);
                EmpresasItem.Name = Empresas_map.Name;
                EmpresasItem.CUIT = Empresas_map.CUIT;
                EmpresasItem.ModifiedDate = DateTime.Now;


                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(int FormaDePagoId, FormaDePagoDtosV dto)
        {
            int FormaDePago_Id = FormaDePagoId;
            var FormaDePagoItem = await _context.FormaDePago.FirstOrDefaultAsync(c => c.Id == FormaDePago_Id);

            if (FormaDePagoItem != null)
            {
                var FormaDePago_map = _mapper.Map<FormaDePago>(dto);
                FormaDePagoItem.Name = FormaDePago_map.Name;
                FormaDePagoItem.ModifiedDate = DateTime.Now;



                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int ImpuestosId, ImpuestosDtosV dto)
        {
            int Impuestos_Id = ImpuestosId;
            var ImpuestosItem = await _context.Impuestos.FirstOrDefaultAsync(c => c.Id == Impuestos_Id);

            if (ImpuestosItem != null)
            {
                var Impuestos_map = _mapper.Map<Impuestos>(dto);
                ImpuestosItem.Name = Impuestos_map.Name;
                ImpuestosItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int InsumosId, InsumosDtosV dto)
        {
            int Insumos_Id = InsumosId;
            var InsumosItem = await _context.Insumos.FirstOrDefaultAsync(c => c.Id == Insumos_Id);

            if (InsumosItem != null)

            {
                var Insumos_map = _mapper.Map<Insumos>(dto);
                InsumosItem.Name = Insumos_map.Name;
                InsumosItem.Cost = Insumos_map.Cost;
                InsumosItem.UnidadesId = Insumos_map.UnidadesId;
                InsumosItem.UnidadesName = Insumos_map.UnidadesName;
                InsumosItem.ModifiedDate = DateTime.Now; 

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int PlanDeCuentasId, PlanDeCuentasDtosV dto)
        {
            int PlanDeCuentas_Id = PlanDeCuentasId;
            var PlanDeCuentasItem = await _context.PlanDeCuentas.FirstOrDefaultAsync(c => c.Id == PlanDeCuentas_Id);

            if (PlanDeCuentasItem != null)
            {
                var PlanDeCuentas_map = _mapper.Map<PlanDeCuentas>(dto);
                PlanDeCuentasItem.Name = PlanDeCuentas_map.Name;
                PlanDeCuentasItem.ShortName = PlanDeCuentas_map.ShortName;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int PorcentajesId, PorcentajesDtosV dto)
        {
            int Porcentajes_Id = PorcentajesId;
            var PorcentajesItem = await _context.Porcentajes.FirstOrDefaultAsync(c => c.Id == Porcentajes_Id);

            if (PorcentajesItem != null)
            {
                var Porcentajes_map = _mapper.Map<Porcentajes>(dto);
                PorcentajesItem.Name = Porcentajes_map.Name;
                PorcentajesItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int PresupuestosId, PresupuestosDtosV dto)
        {
            int Presupuestos_Id = PresupuestosId;
            var PresupuestoItem = await _context.Presupuestos.FirstOrDefaultAsync(c => c.Id == Presupuestos_Id);

            if (PresupuestoItem != null)
            {
                var Presupuesto_map = _mapper.Map<Presupuesto>(dto);
                PresupuestoItem.Name = Presupuesto_map.Name;
                PresupuestoItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int ProveedoresId, ProveedoresDtosV dto)
        {
            int Proveedores_Id = ProveedoresId;
            var ProveedoresItem = await _context.Proveedores.FirstOrDefaultAsync(c => c.Id == Proveedores_Id);

            if (ProveedoresItem != null)
            {
                var Proveedores_map = _mapper.Map<Proveedores>(dto);
                ProveedoresItem.Name = Proveedores_map.Name;
                ProveedoresItem.CUIT = Proveedores_map.CUIT;
                ProveedoresItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int RubrosId, RubrosDtosV dto)
        {
            int Rubros_Id = RubrosId;
            var RubrosItem = await _context.Rubros.FirstOrDefaultAsync(c => c.Id == Rubros_Id);


            if (RubrosItem != null)
            {
                var Rubros_map = _mapper.Map<Rubros>(dto);
                RubrosItem.Name = Rubros_map.Name;
                RubrosItem.ShortName = Rubros_map.ShortName;
                RubrosItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();

            }
        }
        public async Task Update(int SubRubrosId, SubRubrosDtosV dto)
        {
            int SubRubros_Id = SubRubrosId;
            var SubRubrosItem = await _context.SubRubros.FirstOrDefaultAsync(c => c.Id == SubRubros_Id);


            if (SubRubrosItem != null)
            {
                var SubRubros_map = _mapper.Map<SubRubros>(dto);
                SubRubrosItem.Name = SubRubros_map.Name;
                SubRubrosItem.ShortName = SubRubros_map.ShortName;
                SubRubrosItem.ModifiedDate = DateTime.Now;
 


                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int TareasId, TareasDtosV dto)
        {
            int Tareas_Id = TareasId;
            var TareasItem = await _context.Tareas.FirstOrDefaultAsync(c => c.Id == Tareas_Id);


            if (TareasItem != null)
            {
                var Tareas_map = _mapper.Map<Tareas>(dto);
                TareasItem.Name = Tareas_map.Name;
                TareasItem.ShortName = Tareas_map.ShortName;

                TareasItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int TipoDeComprobanteId, TipoDeComprobanteDtosV dto)
        {
            int TipoDeComprobante_Id = TipoDeComprobanteId;
            var TipoDeComprobanteItem = await _context.TipoDeComprobantes.FirstOrDefaultAsync(c => c.Id == TipoDeComprobante_Id);
            
            if (TipoDeComprobanteItem != null)
            {
                var TipoDeComprobantes_map = _mapper.Map<TipoDeComprobante>(dto);
                TipoDeComprobanteItem.Name = TipoDeComprobantes_map.Name;
                TipoDeComprobanteItem.ModifiedDate = DateTime.Now;


                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int TipoDeCostosId, TipoDeCostosDtosV dto)
        {
            int TipoDeCostos_Id = TipoDeCostosId;
            var TipoDeCostoItem = await _context.TipoDeCosto.FirstOrDefaultAsync(c => c.Id == TipoDeCostos_Id);


            if (TipoDeCostoItem != null)
            {
                var TipoDeCosto_map = _mapper.Map<TipoDeCosto>(dto);
                TipoDeCostoItem.Name = TipoDeCosto_map.Name;
                TipoDeCostoItem.ShortName = TipoDeCosto_map.ShortName;
                TipoDeCostoItem.ModifiedDate = DateTime.Now;


                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int TipoDeOperacionesId, TipoDeOperacionesDtosV dto)
        {
            int TipoDeOperaciones_Id = TipoDeOperacionesId;
            var TipoDeOperacionesItem = await _context.TipoDeOperaciones.FirstOrDefaultAsync(c => c.Id == TipoDeOperaciones_Id);

            if (TipoDeOperacionesItem != null)
            {
                var TipoDeOperaciones_map = _mapper.Map<TipoDeOperaciones>(dto);
                TipoDeOperacionesItem.Name = TipoDeOperaciones_map.Name;
                TipoDeOperacionesItem.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
            }
        }
        public async Task Update(int UnidadesId, UnidadesDtosV dto)
        {
            int Unidades_Id = UnidadesId;
            var UnidadesItem = await _context.Unidades.FirstOrDefaultAsync(c => c.Id == Unidades_Id);


            if (UnidadesItem != null)
            {
                var Unidades_map = _mapper.Map<Unidades>(dto);
                UnidadesItem.Name = Unidades_map.Name;
                UnidadesItem.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }

        //llamadas generales de cada lista
        public async Task<List<CentroDeCostos>> GetAllCentroDeCostosAsync()
        {
            return await _context.CentroDeCostos.ToListAsync();
        }
        public async Task<List<Certificados>> GetAllCertificadosAsync()
        {
            return await _context.Certificados.ToListAsync();
        }

        public async Task<List<Egresos>> GetAllEgresosAsync()
        {
            return await _context.Egresos.ToListAsync();
        }
        public async Task<List<Empresas>> GetAllEmpresasAsync()
        {
            return await _context.Empresas.ToListAsync();
        }
        public async Task<List<FormaDePago>> GetAllFormaDePagoAsync()
        {
            return await _context.FormaDePago.ToListAsync();
        }
        public async Task<List<Impuestos>> GetAllImpuestosAsync()
        {
            return await _context.Impuestos.ToListAsync();
        }
 
        public async Task<List<Ingresos>> GetAllIngresosAsync()
        {
            return await _context.Ingresos.ToListAsync();
        }
        public async Task<List<Insumos>> GetAllInsumosAsync()
        {
            return await _context.Insumos.ToListAsync();
        }
        public async Task<List<PlanDeCuentas>> GetAllPlanDeCuentasAsync()
        {
            return await _context.PlanDeCuentas.ToListAsync();
        }
        public async Task<List<Porcentajes>> GetAllPorcentajesAsync()
        {
            return await _context.Porcentajes.ToListAsync();
        }
        public async Task<List<Presupuesto>> GetAllPresupuestoAsync()
        {
            return await _context.Presupuestos.ToListAsync();
        }
        public async Task<List<Proveedores>> GetAllProveedoresAsync()
        {
            return await _context.Proveedores.ToListAsync();
        }
        public async Task<List<Rubros>> GetAllRubrosAsync()
        {
            return await _context.Rubros.ToListAsync();
        }
        public async Task<List<SubRubros>> GetAllSubRubrosAsync()
        {
            return await _context.SubRubros.ToListAsync();
        }
        public async Task<List<Tareas>> GetAllTareasAsync()
        {
            return await _context.Tareas.ToListAsync();
        }
        public async Task<List<TipoDeComprobante>> GetAllTipoDeComprobanteAsync()
        {
            return await _context.TipoDeComprobantes.ToListAsync();
        }
        public async Task<List<TipoDeCosto>> GetAllTipoDeCostoAsync()
        {
            return await _context.TipoDeCosto.ToListAsync();
        }
        public async Task<List<TipoDeOperaciones>> GetAllTipoDeOperacionesAsync()
        {
            return await _context.TipoDeOperaciones.ToListAsync();
        }
        public async Task<List<Unidades>> GetAllUnidadesAsync()
        {
            return await _context.Unidades.ToListAsync();
        }

    }
}
