﻿using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IUpdateTarjetaOutputPort
    {
        Task HandleBloquearTarjeta(int numeroTargeta);
    }
}
