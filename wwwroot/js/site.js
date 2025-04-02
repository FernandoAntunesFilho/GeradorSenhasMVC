// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function atualizarValor() {
    const range = document.getElementById("customRange2");
    const valor = document.getElementById("valorSelecionado");
    valor.textContent = `${range.value} caracteres`;
  }