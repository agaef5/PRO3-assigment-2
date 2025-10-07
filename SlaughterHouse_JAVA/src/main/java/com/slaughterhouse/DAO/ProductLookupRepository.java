package com.slaughterhouse.DAO;

import com.slaughterhouse.Entities.Product;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface ProductLookupRepository {

  @Query("""
         select distinct pi.product
         from ProductItem pi
         join pi.part p
         where p.animal.id = :animalId
         """) List<Product> findProductsByAnimalId(@Param("animalId") Long animalId);
}
