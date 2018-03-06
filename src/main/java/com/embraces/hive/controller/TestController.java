package com.embraces.hive.controller;

import javax.annotation.Resource;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.embraces.hive.service.TestService;

@RestController
@RequestMapping("/hive")
public class TestController {

	private  Logger log = LoggerFactory.getLogger(TestController.class);
	
	@Resource
	private TestService testService;
	
	@RequestMapping("/test")
	public Object test() {
		
		Object ret = testService.test();
		
		log.info("ret:{}", ret);
		
		return ret;
	}
}
