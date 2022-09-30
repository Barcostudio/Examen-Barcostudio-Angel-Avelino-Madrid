@extends('layouts.plantillabase');

@section('contenido')
<h2>CREAR ALUMNO</h2>

<form action="/alumnos" method="POST">
    @csrf
<div class=mb-3>
    <label for="" class="form-label">Id</label>
    <input id="id" name="id" type="text" class="form-control" tabindex="1">
</div>
<div class=mb-3>
    <label for="" class="form-label">Nombre</label>
    <input id="nombre" name="nombre" type="text" class="form-control" tabindex="2">
</div>
<div class=mb-3>
    <label for="" class="form-label">Apellido_paterno</label>
    <input id="apellido_paterno" name="apellido_paterno" type="text" class="form-control" tabindex="3">
</div>
<div class=mb-3>
    <label for="" class="form-label">Apellido_materno</label>
    <input id="apellido_materno" name="apellido_materno" type="text" class="form-control" tabindex="4">
</div>
<div class=mb-3>
    <label for="" class="form-label">Edad</label>
    <input id="edad" name="edad" type="number" class="form-control" tabindex="5">
</div>
<div class=mb-3>
    <label for="" class="form-label">Sexo</label>
    <input id="sexo" name="sexo" type="listBox" class="form-control" tabindex="6">
</div>
<a href="/alumnos" class="btn btn-secondary" tabindex="5">Cancelar</a>
<button type="submit" class="btn btn-primary" tabindex="4">Guardar</button>
</form>
@endsection