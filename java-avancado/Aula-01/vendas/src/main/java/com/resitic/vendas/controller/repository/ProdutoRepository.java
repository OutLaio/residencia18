package com.resitic.vendas.controller.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.resitic.vendas.models.Produto;

@Repository
public interface ProdutoRepository extends JpaRepository<Produto, Long> {

}
