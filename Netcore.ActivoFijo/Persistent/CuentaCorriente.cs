using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class CuentaCorriente : Netcore.ActivoFijo.Entity.CuentaCorriente, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.CuentaCorriente? cuentaCorriente = await context.CuentaCorrientes.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.CuentaCorriente>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.SucursalBancariaId == this.SucursalBancariaId && x.Id == this.Id);

            if (cuentaCorriente == null)
            {
                cuentaCorriente = new CuentaCorriente
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    SucursalBancariaId = this.SucursalBancariaId,
                    Id = this.Id
                };

                await context.CuentaCorrientes.AddAsync(cuentaCorriente);
            }

            cuentaCorriente.Numero = this.Numero;
            cuentaCorriente.Descripcion = this.Descripcion;
            cuentaCorriente.CuentaId = this.CuentaId;
            cuentaCorriente.Saldo = this.Saldo;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.CuentaCorriente? cuentaCorriente = await context.CuentaCorrientes.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.CuentaCorriente>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.SucursalBancariaId == this.SucursalBancariaId && x.Id == this.Id);

            if (cuentaCorriente != null)
            {
                context.CuentaCorrientes.Remove(cuentaCorriente);
            }
        }
    }
}