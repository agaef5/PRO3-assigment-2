package com.slaughterhouse.Entities;
import jakarta.persistence.*;

import java.sql.Time;
import java.sql.Timestamp;

// Animal.java
@Entity @Table(name = "animals")
public class Animal {
  @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @Column(nullable = false, unique = true)
  private String registrationNumber;   // add this for recall/tracing

  @Column(nullable = false)
  private double weight;

  @Column(nullable = false)
  private Timestamp arrivalDate;
  
  @Column (nullable = false)
  private String farm;


  public Long getId()
  {
    return id;
  }

  public void setId(Long id)
  {
    this.id = id;
  }

  public String getRegistrationNumber()
  {
    return registrationNumber;
  }

  public void setRegistrationNumber(String registrationNumber)
  {
    this.registrationNumber = registrationNumber;
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

  public void setFarm(String farm) {this.farm = farm;}

    public String getFarm() {return farm;}

  // getters/setters...
}
