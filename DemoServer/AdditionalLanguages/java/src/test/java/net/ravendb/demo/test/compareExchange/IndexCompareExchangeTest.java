package net.ravendb.demo.test.compareExchange;

import net.ravendb.demo.common.models.Employee;
import net.ravendb.demo.common.models.Product;
import net.ravendb.demo.compareExchange.indexCompareExchange.IndexCompareExchange;
import net.ravendb.demo.javascriptIndexes.javascriptMapIndex.JavascriptMapIndex;
import org.junit.Assert;
import org.junit.Test;

import java.util.List;

public class IndexCompareExchangeTest {
    @Test
    public void test() {
        List<Product> products;
        IndexCompareExchange.RunParams runParams = new IndexCompareExchange.RunParams();
        runParams.setMinValue(25);
        products= new IndexCompareExchange().run(runParams);
        Assert.assertNotNull(products);
    }
}
