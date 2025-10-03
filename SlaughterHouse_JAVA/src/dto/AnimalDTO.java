package dto;

import java.sql.Timestamp;

public record AnimalDTO(int id, double weight, Timestamp arrivalDate)
{
}
