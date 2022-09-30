@extends('layouts.plantillabase3');

@section('contenido2')
<h2>EDITAR CALIFICACION</h2>

<form action="/calificaciones/{{$calificacion->id}}" method="POST">
    @csrf
    @method('PUT')
<div class=mb-3>
    <label for="" class="form-label">Id</label>
    <input id="id" name="id" type="text" class="form-control" value="{{$calificacion->id}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">nalumno</label>
    <input id="nalumno" name="nalumno" type="text" class="form-control" value="{{$calificacion->nalumno}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">nmateria</label>
    <input id="nmateria" name="nmateria" type="text" class="form-control" value="{{$calificacion->nmateria}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">pp</label>
    <input id="pp" name="pp" type="text" class="form-control" value="{{$calificacion->pp}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">sp</label>
    <input id="sp" name="sp" type="text" class="form-control" value="{{$calificacion->sp}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">tp</label>
    <input id="tp" name="tp" type="text" class="form-control" value="{{$calificacion->tp}}">
</div>
<div class=mb-3>
    <label for="" class="form-label">calificacion</label>
    <input id="calificacion" name="calificacion" type="text" class="form-control" value="{{$calificacion->calificacion}}">
</div>
<a href="/calificaciones" class="btn btn-secondary" tabindex="5">Cancelar</a>
<button type="submit" class="btn btn-primary" tabindex="4">Guardar</button>
</form>

@endsection