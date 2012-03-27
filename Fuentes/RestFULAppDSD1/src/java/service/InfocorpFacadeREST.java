/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package service;

import dsd.upc.enty.Infocorp;
import java.util.List;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.ws.rs.*;

/**
 *
 * @author Administrador
 */
@Stateless
@Path("dsd.upc.enty.infocorp")
public class InfocorpFacadeREST extends AbstractFacade<Infocorp> {
    @PersistenceContext(unitName = "RestFULAppDSD1PU")
    private EntityManager em;

    public InfocorpFacadeREST() {
        super(Infocorp.class);
    }

    @POST
    @Override
    @Consumes({"application/xml", "application/json"})
    public void create(Infocorp entity) {
        super.create(entity);
    }

    @PUT
    @Override
    @Consumes({"application/xml", "application/json"})
    public void edit(Infocorp entity) {
        super.edit(entity);
    }

    @DELETE
    @Path("{id}")
    public void remove(@PathParam("id") String id) {
        super.remove(super.find(id));
    }

    @GET
    @Path("{id}")
    @Produces({"application/xml", "application/json"})
    public Infocorp find(@PathParam("id") String id) {
        return super.find(id);
    }

    @GET
    @Override
    @Produces({"application/xml", "application/json"})
    public List<Infocorp> findAll() {
        return super.findAll();
    }

    @GET
    @Path("{from}/{to}")
    @Produces({"application/xml", "application/json"})
    public List<Infocorp> findRange(@PathParam("from") Integer from, @PathParam("to") Integer to) {
        return super.findRange(new int[]{from, to});
    }

    @GET
    @Path("count")
    @Produces("text/plain")
    public String countREST() {
        return String.valueOf(super.count());
    }

    @java.lang.Override
    protected EntityManager getEntityManager() {
        return em;
    }
    
}
