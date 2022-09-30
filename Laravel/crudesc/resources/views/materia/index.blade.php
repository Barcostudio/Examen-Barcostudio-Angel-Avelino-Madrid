@extends('layouts.plantillabase1');

@section('contenido1')
<a href="materias/create" class="btn btn-primary">CREAR</a>

<table class="table tables-dark table-striped mt-4">
    <thead>
        <tr>
            <th scope="col">id</th>
            <th scope="col">descripcion</th>
            <th scope="col">acciones</th>
        </tr>  
    </thead> 
    <tbody>
        @foreach ($materias as $materia)
        <tr>
            <td>{{ $materia->id}}</td>
            <td>{{ $materia->descripcion}}</td>
            <td>
            <form action="{{ route ('materias.destroy', $materia->id)}}" method="POST">
                <a href="/materias/{{ $materia->id}}/edit" class= "btn btn-info">Editar</a>
                @csrf 
                @method('DELETE')
                <button type="submit" class= "btn btn-danger">Borrar</button>
            </form>    
            </td>
        </tr>
        @endforeach
    </tbody> 
@endsection