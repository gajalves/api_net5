using api_net5.Core.Exceptions;
using api_net5.Domain.Entities;
using api_net5.Infra.Interfaces;
using api_net5.Services.DTO;
using api_net5.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_net5.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Create(UserDTO userDTO) 
        {
            User userExists = await _userRepository.GetByEmail(userDTO.Email) ;

            if (userExists != null)
                throw new DomainException("Já existe um usuário com o email informado");

            User user = _mapper.Map<User>(userDTO);
            user.Validate();

            User userCreate = await _userRepository.Create(user);

            return _mapper.Map<UserDTO>(userCreate);
        }

        public async Task<UserDTO> Update(UserDTO userDTO) 
        {
            User userExists = await _userRepository.Get(userDTO.Id);

            if (userExists == null)
                throw new DomainException("Usuário não encontrado com o id informado");

            User user = _mapper.Map<User>(userDTO);
            user.Validate();

            User userCreate = await _userRepository.Update(user);

            return _mapper.Map<UserDTO>(userCreate);
        }

        public async Task Remove(int id) 
        {
            await _userRepository.Remove(id);            
        }

        public async Task<UserDTO> Get(int id) 
        {
            User user = await _userRepository.Get(id);

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> Get() 
        {
            List<User> allUsers = await _userRepository.GetAll();

            return _mapper.Map<List<UserDTO>>(allUsers);
        }

        public async Task<UserDTO> GetByEmail(string email) 
        {
            User user = await _userRepository.GetByEmail(email);

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> SearchByName(string name) 
        {
            List<User> user = await _userRepository.SearchByName(name);

            return _mapper.Map<List<UserDTO>>(user);
        }
    }
}
