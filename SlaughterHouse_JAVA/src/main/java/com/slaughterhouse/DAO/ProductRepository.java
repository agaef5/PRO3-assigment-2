package com.slaughterhouse.DAO;

import com.slaughterhouse.Entities.Product;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProductRepository extends JpaRepository<Product, Long> {}
