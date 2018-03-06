package com.embraces.hive.dao;

import javax.annotation.Resource;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Repository;

@Repository
public class TestDao {
	
	private Logger log = LoggerFactory.getLogger(TestDao.class);
	
	@Resource
	private JdbcTemplate jdbcTemplate;

	public Object test() {
		
		Object ret = jdbcTemplate.queryForList("select * from test limit 100");
		
		log.info("ret: {}", ret);
		
		return ret;
	}
	
	
}
