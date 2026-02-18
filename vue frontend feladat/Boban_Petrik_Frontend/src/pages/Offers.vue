<script>
    import axios from "axios";

    axios.defaults.baseURL = 'http://localhost:5000/api'

    export default
    {
        name: 'Offers',
        data()
        {
            return{
                ingatlanok: []
            }
        },

        mounted()
        {
            axios.get('/ingatlan')
            .then(Response => {
                this.ingatlanok = Response.data
            })
            .catch(error => {
                console.log(error)
            })
            
        }
    }
</script>


<!--táblázatos megjelenítés, ahol a backendről lekért ingatlanok adatai jelennek meg. 
A táblázat oszlopai: Kategória, Leírás, Hirdetés dátuma, Tehermentes, Fénykép. 
Az ingatlanok adatait a backendről lekért ingatlanok tömbjéből kell kinyerni és megjeleníteni a táblázatban.-->
<template>
    <h1 class="text-center pt-2 pt-lg-4">Ajánlataink</h1>
    <table>
        <tr>
            <th>Kategória</th>
            <th>Leírás</th>
            <th>Hirdetés dátuma</th>
            <th>Tehermentes</th>
            <th>Fénykép</th>
        </tr>
        <tr v-for="ingatlan in ingatlanok" :key="ingatlan.id">
            <td class="text-center">{{ingatlan.kategoriaNev}}</td>
            <td>{{ingatlan.leiras}}</td>
            <td class="text-center">{{ingatlan.hirdetesDatuma}}</td>
            <td class="text-center" :class="ingatlan.tehermentes ? 'zold' : 'piros'">{{ingatlan.tehermentes ? "igen" : "nem"}}</td>
            <td class="text-center"><img :src="ingatlan.kepUrl" class="kep"></td>
        </tr>
    </table>
</template>

<style>
 table{
    width: 80%;
    border-collapse: collapse;
    margin: 20px auto;
    box-shadow: 5px 5px 15px gray;
 }

table, th, td{
    border-bottom: 1px solid lightgray;
    padding: 8px;
    text-align: left;
 }

 th{
    background-color: #f2f2f2;
    text-align: center;
 }

 .kep{
    margin: 0 auto;
    height: 100px;
    display: block;
 }

 .zold{
    color: green;
 }

 .piros{
    color: red;
 } 
</style>