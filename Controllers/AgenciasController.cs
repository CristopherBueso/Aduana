using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aduanas.Models;

namespace Aduanas.Controllers
{
    //public class agenciascontroller : controller
    //{
    //    private readonly aduanascontext _context;

    //    public agenciascontroller(aduanascontext context)
    //    {
    //        _context = context;
    //    }

    //    // get: agencias
    //    public async task<iactionresult> index()
    //    {
    //          return view(await _context.agencias.tolistasync());
    //    }

    //    // get: agencias/details/5
    //    public async task<iactionresult> details(int? id)
    //    {
    //        if (id == null || _context.agencias == null)
    //        {
    //            return notfound();
    //        }

    //        var agencia = await _context.agencias
    //            .firstordefaultasync(m => m.idagencia == id);
    //        if (agencia == null)
    //        {
    //            return notfound();
    //        }

    //        return view(agencia);
    //    }

    //    // get: agencias/create
    //    public iactionresult create()
    //    {
    //        return view();
    //    }

    //    // post: agencias/create
    //    // to protect from overposting attacks, enable the specific properties you want to bind to.
    //    // for more details, see http://go.microsoft.com/fwlink/?linkid=317598.
    //    [httppost]
    //    [validateantiforgerytoken]
    //    public async task<iactionresult> create([bind("idagencia,nombreagencia,telefono,direccion,pais")] agencia agencia)
    //    {
    //        if (modelstate.isvalid)
    //        {
    //            _context.add(agencia);
    //            await _context.savechangesasync();
    //            return redirecttoaction(nameof(index));
    //        }
    //        return view(agencia);
    //    }

    //    // get: agencias/edit/5
    //    public async task<iactionresult> edit(int? id)
    //    {
    //        if (id == null || _context.agencias == null)
    //        {
    //            return notfound();
    //        }

    //        var agencia = await _context.agencias.findasync(id);
    //        if (agencia == null)
    //        {
    //            return notfound();
    //        }
    //        return view(agencia);
    //    }

    //    // post: agencias/edit/5
    //    // to protect from overposting attacks, enable the specific properties you want to bind to.
    //    // for more details, see http://go.microsoft.com/fwlink/?linkid=317598.
    //    [httppost]
    //    [validateantiforgerytoken]
    //    public async task<iactionresult> edit(int id, [bind("idagencia,nombreagencia,telefono,direccion,pais")] agencia agencia)
    //    {
    //        if (id != agencia.idagencia)
    //        {
    //            return notfound();
    //        }

    //        if (modelstate.isvalid)
    //        {
    //            try
    //            {
    //                _context.update(agencia);
    //                await _context.savechangesasync();
    //            }
    //            catch (dbupdateconcurrencyexception)
    //            {
    //                if (!agenciaexists(agencia.idagencia))
    //                {
    //                    return notfound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return redirecttoaction(nameof(index));
    //        }
    //        return view(agencia);
    //    }

    //    // get: agencias/delete/5
    //    public async task<iactionresult> delete(int? id)
    //    {
    //        if (id == null || _context.agencias == null)
    //        {
    //            return notfound();
    //        }

    //        var agencia = await _context.agencias
    //            .firstordefaultasync(m => m.idagencia == id);
    //        if (agencia == null)
    //        {
    //            return notfound();
    //        }

    //        return view(agencia);
    //    }

    //    // post: agencias/delete/5
    //    [httppost, actionname("delete")]
    //    [validateantiforgerytoken]
    //    public async task<iactionresult> deleteconfirmed(int id)
    //    {
    //        if (_context.agencias == null)
    //        {
    //            return problem("entity set 'aduanascontext.agencias'  is null.");
    //        }
    //        var agencia = await _context.agencias.findasync(id);
    //        if (agencia != null)
    //        {
    //            _context.agencias.remove(agencia);
    //        }
            
    //        await _context.savechangesasync();
    //        return redirecttoaction(nameof(index));
    //    }

    //    private bool agenciaexists(int id)
    //    {
    //      return _context.agencias.any(e => e.idagencia == id);
    //    }
    //}
}
