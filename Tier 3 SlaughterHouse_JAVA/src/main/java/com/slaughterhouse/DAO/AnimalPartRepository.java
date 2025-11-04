package com.slaughterhouse.DAO;

import com.slaughterhouse.Entities.AnimalPart;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AnimalPartRepository extends JpaRepository<AnimalPart, Long> {}
