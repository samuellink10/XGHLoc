const express = require('express');
const router = express.Router();
const bodyParser = require('body-parser');
router.use(bodyParser.urlencoded({ extended: true }));


router.post('/',function(req,res){
    let teste = req.body.teste;
    console.log("Valor " + teste );
});

router.get('/about',function(req,res){
    console.log("Deu certo ");
    res.send("Deu certo!");
});
module.exports = router;