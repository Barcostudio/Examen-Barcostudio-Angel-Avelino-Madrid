@extends('layouts.plantillabase1');

@section('contenido1')
<h2>CREAR MATERIA</h2>

<form action="/materias" method="POST">
    @csrf
<div class=mb-3>
    <label for="" class="form-label">Id</label>
    <input id="id" name="id" type="text" class="form-control" tabindex="1">
</div>
<div class=mb-3>
    <label for="" class="form-label">descripcion</label>
    <input id="nombre" name="nombre" type="text" class="form-control" tabindex="2">
</div>
<a href="/materias" class="btn btn-secondary" tabindex="5">Cancelar</a>
<button type="submit" class="btn btn-primary" tabindex="4">Guardar</button>
</form>
@endsection