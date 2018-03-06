  <configuration>
    
    <property>
      <name>dfs.domain.socket.path</name>
      <value>/var/lib/hadoop-hdfs/dn_socket</value>
    </property>
    
    <property>
      <name>hbase.bulkload.staging.dir</name>
      <value>/apps/hbase/staging</value>
    </property>
    
    <property>
      <name>hbase.client.keyvalue.maxsize</name>
      <value>1048576</value>
    </property>
    
    <property>
      <name>hbase.client.retries.number</name>
      <value>35</value>
    </property>
    
    <property>
      <name>hbase.client.scanner.caching</name>
      <value>100</value>
    </property>
    
    <property>
      <name>hbase.cluster.distributed</name>
      <value>true</value>
    </property>
    
    <property>
      <name>hbase.coprocessor.master.classes</name>
      <value></value>
    </property>
    
    <property>
      <name>hbase.coprocessor.region.classes</name>
      <value>org.apache.hadoop.hbase.security.access.SecureBulkLoadEndpoint</value>
    </property>
    
    <property>
      <name>hbase.defaults.for.version.skip</name>
      <value>true</value>
    </property>
    
    <property>
      <name>hbase.hregion.majorcompaction</name>
      <value>604800000</value>
    </property>
    
    <property>
      <name>hbase.hregion.majorcompaction.jitter</name>
      <value>0.50</value>
    </property>
    
    <property>
      <name>hbase.hregion.max.filesize</name>
      <value>10737418240</value>
    </property>
    
    <property>
      <name>hbase.hregion.memstore.block.multiplier</name>
      <value>4</value>
    </property>
    
    <property>
      <name>hbase.hregion.memstore.flush.size</name>
      <value>134217728</value>
    </property>
    
    <property>
      <name>hbase.hregion.memstore.mslab.enabled</name>
      <value>true</value>
    </property>
    
    <property>
      <name>hbase.hstore.blockingStoreFiles</name>
      <value>10</value>
    </property>
    
    <property>
      <name>hbase.hstore.compaction.max</name>
      <value>10</value>
    </property>
    
    <property>
      <name>hbase.hstore.compactionThreshold</name>
      <value>3</value>
    </property>
    
    <property>
      <name>hbase.local.dir</name>
      <value>${hbase.tmp.dir}/local</value>
    </property>
    
    <property>
      <name>hbase.master.info.bindAddress</name>
      <value>0.0.0.0</value>
    </property>
    
    <property>
      <name>hbase.master.info.port</name>
      <value>16010</value>
    </property>
    
    <property>
      <name>hbase.master.namespace.init.timeout</name>
      <value>2400000</value>
    </property>
    
    <property>
      <name>hbase.master.port</name>
      <value>16000</value>
    </property>
    
    <property>
      <name>hbase.master.ui.readonly</name>
      <value>false</value>
    </property>
    
    <property>
      <name>hbase.master.wait.on.regionservers.timeout</name>
      <value>30000</value>
    </property>
    
    <property>
      <name>hbase.region.server.rpc.scheduler.factory.class</name>
      <value>org.apache.hadoop.hbase.ipc.PhoenixRpcSchedulerFactory</value>
    </property>
    
    <property>
      <name>hbase.regionserver.executor.openregion.threads</name>
      <value>20</value>
    </property>
    
    <property>
      <name>hbase.regionserver.global.memstore.size</name>
      <value>0.4</value>
    </property>
    
    <property>
      <name>hbase.regionserver.handler.count</name>
      <value>30</value>
    </property>
    
    <property>
      <name>hbase.regionserver.info.port</name>
      <value>16030</value>
    </property>
    
    <property>
      <name>hbase.regionserver.port</name>
      <value>16020</value>
    </property>
    
    <property>
      <name>hbase.regionserver.wal.codec</name>
      <value>org.apache.hadoop.hbase.regionserver.wal.IndexedWALEditCodec</value>
    </property>
    
    <property>
      <name>hbase.rootdir</name>
      <value>hdfs://master.embracesource.com:8020/apps/hbase/data</value>
    </property>
    
    <property>
      <name>hbase.rpc.protection</name>
      <value>authentication</value>
    </property>
    
    <property>
      <name>hbase.rpc.timeout</name>
      <value>90000</value>
    </property>
    
    <property>
      <name>hbase.security.authentication</name>
      <value>simple</value>
    </property>
    
    <property>
      <name>hbase.security.authorization</name>
      <value>false</value>
    </property>
    
    <property>
      <name>hbase.superuser</name>
      <value>hbase</value>
    </property>
    
    <property>
      <name>hbase.table.sanity.checks</name>
      <value>false</value>
    </property>
    
    <property>
      <name>hbase.tmp.dir</name>
      <value>/tmp/hbase-${user.name}</value>
    </property>
    
    <property>
      <name>hbase.zookeeper.property.clientPort</name>
      <value>2181</value>
    </property>
    
    <property>
      <name>hbase.zookeeper.quorum</name>
      <value>master.embracesource.com</value>
    </property>
    
    <property>
      <name>hbase.zookeeper.useMulti</name>
      <value>true</value>
    </property>
    
    <property>
      <name>hfile.block.cache.size</name>
      <value>0.4</value>
    </property>
    
    <property>
      <name>phoenix.functions.allowUserDefinedFunctions</name>
      <value>true</value>
    </property>
    
    <property>
      <name>phoenix.query.timeoutMs</name>
      <value>60000</value>
    </property>
    
    <property>
      <name>zookeeper.recovery.retry</name>
      <value>6</value>
    </property>
    
    <property>
      <name>zookeeper.session.timeout</name>
      <value>90000</value>
    </property>
    
    <property>
      <name>zookeeper.znode.parent</name>
      <value>/hbase-unsecure</value>
    </property>
    
  </configuration>