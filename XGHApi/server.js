const app = require('./app');
const port = 3000;
const bodyParser = require('body-parser');
app.use(bodyParser.json()); 



const userController = require('./controllers/userController')
app.use('/user',userController);



app.listen(port,(err) => {  
    if (err) {
      return console.log('something bad happened', err)
    }
    console.log(`server is listening on ${port}`)
  });