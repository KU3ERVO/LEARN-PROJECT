package com.acc.datos.hybernate_project.servicios;

import com.acc.datos.hybernate_project.pojos.Departamento;
import com.acc.datos.hybernate_project.pojos.Empleado;
import com.acc.datos.hybernate_project.pojos.Sede;
import com.acc.datos.hybernate_project.repositorios.DepartamentoRepository;
import com.acc.datos.hybernate_project.repositorios.EmpleadoRepository;
import com.acc.datos.hybernate_project.repositorios.SedeRepository;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class SetupService55 {

    @Autowired
    private SedeRepository sedeRepository;
    @Autowired
    private DepartamentoRepository departamentoRepository;
    @Autowired
    private EmpleadoRepository empleadoRepository;

    @Transactional
    public void createStructureAngel(){

        Sede sedeKorax = new Sede();
        sedeKorax.setNomSede("KORAX");

        Sede sedeSaved = sedeRepository.saveAndFlush(sedeKorax);
        System.out.println("SEDE CREADA " + sedeSaved.getIdSede());


        Departamento departamentoDev = new Departamento();
        departamentoDev.setNomDepto("Developement");
        departamentoDev.setSede(sedeSaved);
        Departamento depDevSaved = departamentoRepository.saveAndFlush(departamentoDev);
        System.out.println("DEP CREADO" + depDevSaved.getIdDepto());

        Departamento departamentoDesign = new Departamento();
        departamentoDesign.setNomDepto("Design");
        departamentoDesign.setSede(sedeSaved);
        Departamento depDesSaved = departamentoRepository.saveAndFlush(departamentoDesign);
        System.out.println("DEP CREADO" + depDesSaved.getIdDepto());

        Empleado empleadoKorax1 = new Empleado();
        empleadoKorax1.setDni("11111111I");
        empleadoKorax1.setNomEmp("Lito");
        empleadoKorax1.setDepartamento(departamentoDesign);
        empleadoRepository.save(empleadoKorax1);
        System.out.println("NUEVO EMPLEADO " + empleadoKorax1.getDni());

        Empleado empleadoKorax2 = new Empleado();
        empleadoKorax2.setDni("22222222A");
        empleadoKorax2.setNomEmp("Angie");
        empleadoKorax2.setDepartamento(departamentoDev);
        empleadoRepository.save(empleadoKorax2);
        System.out.println("NUEVO EMPLEADO " + empleadoKorax2.getDni());

    }

}
