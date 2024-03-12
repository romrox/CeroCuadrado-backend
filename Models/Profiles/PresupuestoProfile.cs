using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProyectoCeroCuadrado.Entities;
using CeroCuadrado.Models.Dtos.Dtos_Creat;
using CeroCuadrado.Entities;
using CeroCuadrado.Models.Dtos.Dtos_View;


namespace CeroCuadrado.Models.Profiles
{
    public class PresupuestoProfile : Profile
    {
        public PresupuestoProfile()
        {
            CreateMap<CentroDeCostos, CentroDeCostosDtosC>();
            CreateMap<CentroDeCostosDtosC, CentroDeCostos>();
            CreateMap<CentroDeCostos, CentroDeCostosDtosV>();
            CreateMap<CentroDeCostosDtosV, CentroDeCostos>();

            CreateMap<Certificados, CertificadosDtosC>();
            CreateMap<CertificadosDtosC, Certificados>();
            CreateMap<Certificados, CertificadosDtosV>();
            CreateMap<CertificadosDtosV, Certificados>();

            CreateMap<Egresos, EgresosDtosC>();
            CreateMap<EgresosDtosC, Egresos>();
            CreateMap<Egresos, EmpresasDtosV>();
            CreateMap<EmpresasDtosV, Egresos>();

            CreateMap<Empresas, EmpresasDtosC>();
            CreateMap<EmpresasDtosC, Empresas>();
            CreateMap<Empresas, EmpresasDtosV>();
            CreateMap<EmpresasDtosV, Empresas>();

            CreateMap<FormaDePago, FormaDePagoDtosC>();
            CreateMap<FormaDePagoDtosC, FormaDePago>();
            CreateMap<FormaDePago, FormaDePagoDtosV>();
            CreateMap<FormaDePagoDtosV, FormaDePago>();

            CreateMap<Impuestos, ImpuestosDtosC>();
            CreateMap<ImpuestosDtosC, Impuestos>();
            CreateMap<Impuestos, ImpuestosDtosV>();
            CreateMap<ImpuestosDtosV, Impuestos>();

            CreateMap<Ingresos, IngresosDtosC>();
            CreateMap<IngresosDtosC, Ingresos>();
            CreateMap<Ingresos, IngresosDtosV>();
            CreateMap<IngresosDtosV, Ingresos>();

            CreateMap<Insumos, InsumosDtosC>();
            CreateMap<InsumosDtosC, Insumos>();
            CreateMap<Insumos, InsumosDtosV>();
            CreateMap<InsumosDtosV, Insumos>();

            CreateMap<PlanDeCuentas, PlanDeCuentasDtosC>(); 
            CreateMap<PlanDeCuentasDtosC, PlanDeCuentas>();
            CreateMap<PlanDeCuentas, PlanDeCuentasDtosV>();
            CreateMap<PlanDeCuentasDtosV, PlanDeCuentas>();

            CreateMap<Porcentajes, PorcentajesDtosC>();
            CreateMap<PorcentajesDtosC, Porcentajes>();
            CreateMap<Porcentajes, PorcentajesDtosV>();
            CreateMap<PorcentajesDtosV, Porcentajes>();

            CreateMap<Presupuesto, PresupuestoDtosC>();
            CreateMap<PresupuestoDtosC, Presupuesto>();
            CreateMap<Presupuesto, PresupuestosDtosV>();
            CreateMap<PresupuestosDtosV, Presupuesto>();

            CreateMap<Proveedores, ProveedoresDtosC>();
            CreateMap<ProveedoresDtosC, Proveedores>();
            CreateMap<Proveedores, ProveedoresDtosV>();
            CreateMap<ProveedoresDtosV, Proveedores>();

            CreateMap<Rubros, RubrosDtosC>();
            CreateMap<RubrosDtosC, Rubros>();
            CreateMap<Rubros, RubrosDtosV>();
            CreateMap<RubrosDtosV, Rubros>();

            CreateMap<SubRubros, SubRubrosDtosC>();
            CreateMap<SubRubrosDtosC, SubRubros>();
            CreateMap<SubRubros, SubRubrosDtosV>();
            CreateMap<SubRubrosDtosV, SubRubros>();

            CreateMap<Tareas, TareasDtosC>();
            CreateMap<TareasDtosC, Tareas>();
            CreateMap<Tareas, TareasDtosV>();
            CreateMap<TareasDtosV, Tareas>();

            CreateMap<TipoDeComprobante, TipoDeComprobanteDtosC>();
            CreateMap<TipoDeComprobanteDtosC, TipoDeComprobante>();
            CreateMap<TipoDeComprobante, TipoDeComprobanteDtosV>();
            CreateMap<TipoDeComprobanteDtosV, TipoDeComprobante>();

            CreateMap<TipoDeCosto, TipoDeCostoDtosC>();
            CreateMap<TipoDeCostoDtosC, TipoDeCosto>();
            CreateMap<TipoDeCosto, TipoDeCostosDtosV>();
            CreateMap<TipoDeCostosDtosV, TipoDeCosto>();

            CreateMap<TipoDeOperaciones, TipoDeOperacionesDtosC>();
            CreateMap<TipoDeOperacionesDtosC, TipoDeOperaciones>();
            CreateMap<TipoDeOperaciones, TipoDeOperacionesDtosV>();
            CreateMap<TipoDeOperacionesDtosV, TipoDeOperaciones>();

            CreateMap<Unidades, UnidadesDtosC>();
            CreateMap<UnidadesDtosC, Unidades>();
            CreateMap<Unidades, UnidadesDtosV>();
            CreateMap<UnidadesDtosV, Unidades>();



        }
    }
}
