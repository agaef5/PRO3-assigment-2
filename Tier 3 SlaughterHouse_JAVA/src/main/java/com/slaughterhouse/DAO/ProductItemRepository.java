package com.slaughterhouse.DAO;

import com.slaughterhouse.Entities.ProductItem;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.*;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface ProductItemRepository extends JpaRepository<ProductItem, Long> {

  @Query("""
         select distinct a.registrationNumber
         from ProductItem pi
         join pi.part p
         join p.animal a
         where pi.product.id = :productId
         """) List<String> findAnimalRegNumbersByProductId(@Param("productId") Long productId);
}
