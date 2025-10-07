package com.slaughterhouse.Entities;

import jakarta.persistence.*;

import java.sql.Timestamp;

// AnimalPart.java
@Entity @Table(name = "animal_parts")
public class AnimalPart {
  @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @ManyToOne(optional = false, fetch = FetchType.LAZY)
  @JoinColumn(name = "animal_id")
  private Animal animal;

  @Column(nullable = false)
  private String partType;          // or an enum

  @Column(nullable = false)
  private double weight;

  @Column(nullable = false)
  private Timestamp arrivalDate;

  @ManyToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "tray_id")
  private Tray tray;                // optional until assigned to a tray

  public Long getId()
  {
    return id;
  }

  public void setId(Long id)
  {
    this.id = id;
  }

  public Animal getAnimal()
  {
    return animal;
  }

  public void setAnimal(Animal animal)
  {
    this.animal = animal;
  }

  public String getPartType()
  {
    return partType;
  }

  public void setPartType(String partType)
  {
    this.partType = partType;
  }

  public double getWeight()
  {
    return weight;
  }

  public void setWeight(double weight)
  {
    this.weight = weight;
  }

  public Timestamp getArrivalDate()
  {
    return arrivalDate;
  }

  public void setArrivalDate(Timestamp arrivalDate)
  {
    this.arrivalDate = arrivalDate;
  }

  public Tray getTray()
  {
    return tray;
  }

  public void setTray(Tray tray)
  {
    this.tray = tray;
  }

  // getters/setters...
}
