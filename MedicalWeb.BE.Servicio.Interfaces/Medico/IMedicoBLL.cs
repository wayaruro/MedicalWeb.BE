﻿using MedicalWeb.BE.Transversales.Entidades;
namespace MedicalWeb.BE.Servicio.Interfaces;

public interface IMedicoBLL
{
    Task<IEnumerable<Medico>> GetAllAsync();
    Task<Medico> GetByIdAsync(string id);
    Task<Medico> InsertAsync(Medico medico);
    Task<Medico> UpdateAsync(Medico medico);
    Task DeleteAsync(string id);
}