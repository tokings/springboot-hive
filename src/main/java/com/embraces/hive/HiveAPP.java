package com.embraces.hive;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.context.annotation.ComponentScan;

@ComponentScan(basePackages = { "com.embraces.hive"})
@EnableAutoConfiguration
public class HiveAPP {
	
	public static void main(String[] args) {
		
		SpringApplication.run(HiveAPP.class, args);
	}

//	@Bean
//	public MappingJackson2HttpMessageConverter customJackson2HttpMessageConverter() {
//		MappingJackson2HttpMessageConverter jsonConverter = new MappingJackson2HttpMessageConverter();
//		ObjectMapper objectMapper = PojoMapper.getObjectMapper();
//		jsonConverter.setObjectMapper(objectMapper);
//		return jsonConverter;
//	}
	
}
