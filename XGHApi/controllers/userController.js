const express = require('express');
const router = express.Router();
const bodyParser = require('body-parser');
//router.use(bodyParser.urlencoded({ extended: true }));


router.post('/',function(req,res){
    let teste = req.body.teste;
    console.log("Valor " + teste);
    res.send("Valor " + teste);
});

router.get('/about',function(req,res){
    let teste = req.query.teste;
    console.log(teste);
    res.send("Deu certo!"); 
});
module.exports = router;