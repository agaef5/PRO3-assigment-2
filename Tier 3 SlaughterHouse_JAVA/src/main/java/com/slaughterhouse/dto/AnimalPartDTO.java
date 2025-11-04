package com.slaughterhouse.dto;

import java.sql.Timestamp;

public record AnimalPartDTO(int id, int partID, double weight, Timestamp arrivalDate)
{
}
