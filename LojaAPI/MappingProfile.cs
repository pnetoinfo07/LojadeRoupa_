﻿using AutoMapper;
using LojaAPI.Controllers.DTO.Categoria;
using LojaAPI.Controllers.DTO.Cliente;
using LojaAPI.Controllers.DTO.Estoque;
using LojaAPI.Controllers.DTO.Pedido;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._03_Entidades;

namespace LojaAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProdutoDto, Produto>().ReverseMap();
            CreateMap<CreateCategoriaDto, Categoria>().ReverseMap();
            CreateMap<CreateEstoqueDto, Estoque>().ReverseMap();
            CreateMap<CreateClienteDto, Cliente>().ReverseMap();
            CreateMap<CreatePedidoDto, Pedido>().ReverseMap();


        }
    }
}
