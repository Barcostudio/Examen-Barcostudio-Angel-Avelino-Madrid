@extends('layouts.plantillabase');

@section('contenido')
<a href="alumnos/create" class="btn btn-primary">CREAR</a>

<table class="table tables-dark table-striped mt-4">
    <thead>
        <tr>
            <th scope="col">id</th>
            <th scope="col">nombre</th>
            <th scope="col">apellido_paterno</th>
            <th scope="col">apellido_materno</th>
            <th scope="col">edad</th>
            <th scope="col">sexo</th>
            <th scope="col">acciones</th>
        </tr>  
    </thead>  
    <tbody>
        @foreach($alumnos as $alumno)
        <tr>
            <td>{{ $alumno->id}}</td>
            <td>{{ $alumno->nombre}}</td>
            <td>{{ $alumno->apellido_paterno}}</td>
            <td>{{ $alumno->apellido_materno}}</td>
            <td>{{ $alumno->edad}}</td>
            <td>{{ $alumno->sexo}}</td>
            <td>
                <form action="{{ route ('alumnos.destroy', $alumno->id)}}" method="POST">
                <a href="/alumnos/{{ $alumno->id}}/edit" class="btn btn-info">Editar</a>
                @csrf 
                @method('DELETE')
                <button class="btn btn-danger">Borrar</button>
                </form>
            </td>
        </tr>    

        <script>

    let url = 'http://127.0.0.1:8000/api/alumnos/';
    //let url = 'http://localhost:5236/api/Alumno/Lista';


    new Vue({
      el: '#app',
      vuetify: new Vuetify(),
       data() {
        return {            
            alumnos: [],
            dialog: false,
            operacion: '',            
            alumno:{
                idAlumno: null,
                Nombre:'',
                Apellido_Pa:'',
                Apellido_Ma:'',
                edad:'',
                sexo:''
            }          
        }
       },
       created(){               
            this.mostrar()
       },  
       methods:{          
            //MÉTODOS PARA EL CRUD
            mostrar:function(){
              axios.get(url)
              .then(response =>{
                this.alumnos = response.data;                   
              })
            },
            //GUARDAR
            crear:function(){
                let parametros = {Nombre:this.alumno.Nombre, Apellido_Pa:this.alumno.Apellido_Pa, Apellido_Ma:this.alumno.Apellido_Ma, edad:this.alumno.edad, sexo:this.alumno.sexo };                
                axios.post(url, parametros)
                .then(response =>{
                  this.mostrar();
                });     
                this.alumno.Nombre="";
                this.alumno.Apellido_Pa="";
                this.alumno.Apellido_Ma="";
                this.alumno.edad="";
                this.alumno.sexo="";
            },   
            //editar
            editar: function(){
            let parametros = {Nombre:this.alumno.Nombre, Apellido_Pa:this.alumno.Apellido_Pa, Apellido_Ma:this.alumno.Apellido_Ma, edad:this.alumno.edad, sexo:this.alumno.sexo, idAlumno:this.alumno.idAlumno};                            
            //console.log(parametros);                   
                 axios.put(url+this.alumno.idAlumno, parametros)                            
                  .then(response => {                                
                     this.mostrar();
                  })                
                  .catch(error => {
                      console.log(error);            
                  });
            },
            //eliminar
            borrar:function(idAlumno){
             Swal.fire({
                title: '¿Confirma eliminar el registro? '+idAlumno,   
                confirmButtonText: `Confirmar`,                  
                showCancelButton: true,                          
              }).then((result) => {                
                if (result.isConfirmed) {      
                      //procedimiento borrar
                      axios.delete(url+idAlumno)
                      .then(response =>{           
                          this.mostrar();
                       });      
                      Swal.fire('¡Eliminado!', '', 'success')
                } else if (result.isDenied) {                  
                }
              });              
            },
    
            //Botones y formularios
            guardar:function(){
              if(this.operacion=='crear'){
                this.crear();                
              }
              if(this.operacion=='editar'){ 
                this.editar();                           
              }
              this.dialog=false;                        
            }, 
            formNuevo:function () {
              this.dialog=true;
              this.operacion='crear';
              this.alumno.Nombre='';
                this.alumno.Apellido_Pa='';
                this.alumno.Apellido_Ma='';
                this.alumno.edad='';
                this.alumno.sexo='';
            },
            formEditar:function(idAlumno, Nombre, Apellido_Pa, Apellido_Ma,edad, sexo){
              //capturamos los datos del registro seleccionado y los mostramos en el formulario
              this.alumno.idAlumno = idAlumno;
              this.alumno.Nombre = Nombre;
              this.alumno.Apellido_Pa = Apellido_Pa;
              this.alumno.Apellido_Ma = Apellido_Ma;
              this.alumno.edad = edad;
              this.alumno.sexo = sexo;
              this.dialog=true;                            
              this.operacion='editar';
            }
       }      
    });
  </script>
        @endforeach
    </tbody>       
</table>
@endsection

