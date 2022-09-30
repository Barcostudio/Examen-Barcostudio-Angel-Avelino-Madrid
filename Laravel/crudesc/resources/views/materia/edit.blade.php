@extends('layouts.plantillabase');

@section('contenido')
<h2>EDITAR MATERIA</h2>

<form action="/materias/{{$materia->id}}" method="POST">
    @csrf
    @method('PUT')
<div class=mb-3>
    <label for="" class="form-label">Id</label>
    <input id="id" name="id" type="text" class="form-control" value="{{$materia->id}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">Descripcion</label>
    <input id="descripcion" name="descripcion" type="text" class="form-control" value="{{$materia->descripcion}}">
</div>
<a href="/materias" class="btn btn-secondary" tabindex="5">Cancelar</a>
<button type="submit" class="btn btn-primary" tabindex="4">Guardar</button>
</form>

@endsection