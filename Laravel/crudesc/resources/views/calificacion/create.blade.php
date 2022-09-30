@extends('layouts.plantillabase3');

@section('contenido2')
<h2>CREAR CALIFICACION</h2>

<form action="/calificaciones" method="POST">
    @csrf
<div class=mb-3>
    <label for="" class="form-label">id</label>
    <input id="id" name="id" type="text" class="form-control" tabindex="1">
</div>
<div class=mb-3>
    <label for="" class="form-label">nalumno</label>
    <input id="nalumno" name="nalumno" type="number" class="form-control" tabindex="2">
</div>
<div class=mb-3>
    <label for="" class="form-label">nmateria</label>
    <input id="nmateria" name="nmateria" type="number" class="form-control" tabindex="3">
</div>
<div class=mb-3>
    <label for="" class="form-label">pp</label>
    <input id="pp" name="pp" type="number" class="form-control" tabindex="4">
</div>
<div class=mb-3>
    <label for="" class="form-label">sp</label>
    <input id="sp" name="sp" type="number" class="form-control" tabindex="5">
</div>
<div class=mb-3>
    <label for="" class="form-label">tp</label>
    <input id="tp" name="tp" type="number" class="form-control" tabindex="6">
</div>
<div class=mb-3>
    <label for="" class="form-label">calificacion</label>
    <input id="calificacion" name="calificacion" type="number" class="form-control" tabindex="7">
</div>

<a href="/calificaciones" class="btn btn-secondary" tabindex="5">Cancelar</a>
<button type="submit" class="btn btn-primary" tabindex="4">Guardar</button>
</form>

@endsection
