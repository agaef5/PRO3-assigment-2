package com.slaughterhouse.DAO;

import com.slaughterhouse.Entities.Animal;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface AnimalRepository extends JpaRepository<Animal, Long>
{
  Optional<Animal> findByRegistrationNumber(String regNo);
}

