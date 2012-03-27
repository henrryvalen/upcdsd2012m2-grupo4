/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package dsd.upc.enty;

import java.io.Serializable;
import javax.persistence.*;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Administrador
 */
@Entity
@Table(name = "INFOCORP")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Infocorp.findAll", query = "SELECT i FROM Infocorp i"),
    @NamedQuery(name = "Infocorp.findByRuc", query = "SELECT i FROM Infocorp i WHERE i.ruc = :ruc"),
    @NamedQuery(name = "Infocorp.findByClasificacion", query = "SELECT i FROM Infocorp i WHERE i.clasificacion = :clasificacion"),
    @NamedQuery(name = "Infocorp.findByPctMorosidad", query = "SELECT i FROM Infocorp i WHERE i.pctMorosidad = :pctMorosidad"),
    @NamedQuery(name = "Infocorp.findByClaseRiesgo", query = "SELECT i FROM Infocorp i WHERE i.claseRiesgo = :claseRiesgo")})
public class Infocorp implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 12)
    @Column(name = "RUC")
    private String ruc;
    @Size(max = 100)
    @Column(name = "CLASIFICACION")
    private String clasificacion;
    @Column(name = "PCT_MOROSIDAD")
    private Integer pctMorosidad;
    @Size(max = 2)
    @Column(name = "CLASE_RIESGO")
    private String claseRiesgo;

    public Infocorp() {
    }

    public Infocorp(String ruc) {
        this.ruc = ruc;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public String getClasificacion() {
        return clasificacion;
    }

    public void setClasificacion(String clasificacion) {
        this.clasificacion = clasificacion;
    }

    public Integer getPctMorosidad() {
        return pctMorosidad;
    }

    public void setPctMorosidad(Integer pctMorosidad) {
        this.pctMorosidad = pctMorosidad;
    }

    public String getClaseRiesgo() {
        return claseRiesgo;
    }

    public void setClaseRiesgo(String claseRiesgo) {
        this.claseRiesgo = claseRiesgo;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (ruc != null ? ruc.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Infocorp)) {
            return false;
        }
        Infocorp other = (Infocorp) object;
        if ((this.ruc == null && other.ruc != null) || (this.ruc != null && !this.ruc.equals(other.ruc))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "dsd.upc.enty.Infocorp[ ruc=" + ruc + " ]";
    }
    
}
