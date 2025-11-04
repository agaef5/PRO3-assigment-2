package com.slaughterhouse.Entities;

import jakarta.persistence.*;

import java.util.ArrayList;
import java.util.List;

// Tray.java
@Entity @Table(name = "trays")
public class Tray {
  @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @Column(nullable = false)
  private String partType;

  @Column(nullable = false)
  private double currentWeight;

  @Column(nullable = false)
  private double maxCapacity;

  @OneToMany(mappedBy = "tray")
  private List<AnimalPart> parts = new ArrayList<>();

  public Long getId()
  {
    return id;
  }

  public String getPartType()
  {
    return partType;
  }

  public void setPartType(String partType)
  {
    this.partType = partType;
  }

  public double getCurrentWeight()
  {
    return currentWeight;
  }

  public void setCurrentWeight(double currentWeight)
  {
    this.currentWeight = currentWeight;
  }

  public double getMaxCapacity()
  {
    return maxCapacity;
  }

  public void setMaxCapacity(double maxCapacity)
  {
    this.maxCapacity = maxCapacity;
  }
}

