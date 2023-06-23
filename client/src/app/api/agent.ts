import axios, { AxiosResponse } from "axios";
import { Starship } from "../models/starship";

axios.defaults.baseURL = "http://localhost:5293/api/";

const responseBody = (response: AxiosResponse) => response.data;

function createFormData(item: any) {
    let formData = new FormData();
    for (const key in item) {
        formData.append(key, item[key])
    }
    return formData;
}

const requests = {
    get: (url: string) => axios.get(url).then(responseBody),
    post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
    put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody),
    postForm: (url: string, data: FormData) => axios.post(url, data, {
        headers: {'Content-type': 'multipart/form-data'}
    }).then(responseBody),
    putForm: (url: string, data: FormData) => axios.put(url, data, {
        headers: {'Content-type': 'multipart/form-data'}
    }).then(responseBody)
}

const Starships = {
    list: () => requests.get('starships/list'),
    details: (id: number) => requests.get(`starships/${id}`),
    random: () => requests.get('starships/random'),
    create: (values: any) => requests.postForm('starships', createFormData(values)),
    //create: (values: any) => requests.post('starships', values),
    update: (values: any) => requests.putForm('starships', createFormData(values)),
    delete: (id: number) => requests.delete(`starships/${id}`)
}

const agent = {
    Starships
}

export default agent;