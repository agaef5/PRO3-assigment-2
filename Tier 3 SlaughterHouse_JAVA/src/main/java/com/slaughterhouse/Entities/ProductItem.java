package com.slaughterhouse.Entities;

import jakarta.persistence.*;

// ProductItem.java (join entity)
@Entity @Table(name = "product_items")
public class ProductItem {
  @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @ManyToOne(optional = false, fetch = FetchType.LAZY)
  @JoinColumn(name = "product_id")
  private Product product;

  @ManyToOne(optional = false, fetch = FetchType.LAZY)
  @JoinColumn(name = "part_id")
  private AnimalPart part;

  public Long getId()
  {
    return id;
  }

  public void setId(Long id)
  {
    this.id = id;
  }

  public Product getProduct()
  {
    return product;
  }

  public void setProduct(Product product)
  {
    this.product = product;
  }

  public AnimalPart getPart()
  {
    return part;
  }

  public void setPart(AnimalPart part)
  {
    this.part = part;
  }
}

