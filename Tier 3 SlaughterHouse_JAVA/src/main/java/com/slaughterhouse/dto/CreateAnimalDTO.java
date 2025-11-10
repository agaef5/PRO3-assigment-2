package com.slaughterhouse.dto;

import java.sql.Timestamp;

public record CreateAnimalDTO(double weight, Timestamp arrivalDate, String farm) {}