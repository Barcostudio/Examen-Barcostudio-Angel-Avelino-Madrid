@extends('layouts.plantillabase3');

@section('contenido2')
<a href="calificaciones/create" class="btn btn-primary">CREAR</a>

<table class="table tables-dark table-striped mt-4">
    <thead>
        <tr>
            <th scope="col">id</th>
            <th scope="col">nalumno</th>
            <th scope="col">nmateria</th>
            <th scope="col">pp</th>
            <th scope="col">sp</th>
            <th scope="col">tp</th>
            <th scope="col">calificacion</th>
            <th scope="col">acciones</th>
        </tr>  
    </thead>  
    <tbody>
    @foreach ($calificaciones as $calificacion)
        <tr>
            <td>{{ $calificacion->id}}</td>
            <td>{{ $calificacion->nalumno}}</td>
            <td>{{ $calificacion->nmateria}}</td>
            <td>{{ $calificacion->pp}}</td>
            <td>{{ $calificacion->sp}}</td>
            <td>{{ $calificacion->tp}}</td>
            <td>{{ $calificacion->calificacion}}</td>
            <td>
                <form action= "{{ route ('calificaciones.destroy',$calificacion->id)}}" method="POST">
                <a href="/calificaciones/{{ $calificacion->id}}/edit" class="btn btn-info">Editar</a>
                @csrf 
                @method('DELETE')
                <button class="btn btn-danger">Borrar</button>
                </form>
            </td>
        </tr> 
        @endforeach   
    </tbody>
@endsection